using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using System.Xml.Serialization;
using WeightLog.Commands;
using WeightLog.Models;

namespace WeightLog.ViewModels
{
    public class WeightViewModel : ViewModelBase
    {
		private List<string> _labels;
		public List<string> Labels
		{
			get
			{
				return _labels;
			}
			set
			{
				_labels = value;
				OnPropertyChanged(nameof(Labels));
			}
		}

		private ObservableCollection<WeightObjectViewModel> _weights;
		public ObservableCollection<WeightObjectViewModel> Weights
		{
			get
			{
				return _weights;
			}
			set
			{
				if (_weights != value)
				{
					_weights = value;
					OnPropertyChanged(nameof(Weights));
				}
			}
		}

		private SeriesCollection _series;
		public SeriesCollection Series
		{
			get
			{
				return _series;
			}
			set
			{
				_series = value;
				OnPropertyChanged(nameof(Series));
			}
		}

		//Label formater to limit the y-axis to a double with only 1 digit after the decimal.
		public Func<double, string> OneDigit => value => value.ToString("N1");

        public ICommand AddWeight { get; }

		public ICommand RemoveWeight { get; }

		public WeightViewModel(WeightList weightList)
		{
			try
			{
				Weights = LoadFromXml("data.xml");
			}

			catch (Exception ex)
			{
				Weights = new ObservableCollection<WeightObjectViewModel>();

			}

			Labels = new List<string>();

			Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Weight",
					Values = new ChartValues<double>()
				}
			};

			Labels.AddRange(Weights.Select(weight => weight.Date));

			Series[0].Values = new ChartValues<double>(Weights.Select(weight => weight.WeightNum));
			
			AddWeight = new AddWeightCommand(this);
			//RemoveWeight = new RemoveWeightCommand();
		}

        public void UpdateChart()
        {
            Series[0].Values = new ChartValues<double>(Weights.Select(weight => weight.WeightNum));
            Labels.Clear();
            Labels.AddRange(Weights.Select(weight => weight.Date));
        }

        public void SaveToXml(ObservableCollection<WeightObjectViewModel> collection, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<WeightObjectViewModel>));

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, collection);
            }
        }

        public ObservableCollection<WeightObjectViewModel> LoadFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<WeightObjectViewModel>));

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (ObservableCollection<WeightObjectViewModel>)serializer.Deserialize(fs);
            }
        }
    }
}
