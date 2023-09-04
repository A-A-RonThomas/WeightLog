using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Input;
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

		public Func<double, string> OneDigit => value => value.ToString("N1");

        public ICommand AddWeight { get; }


		public WeightViewModel(WeightList weightList)
		{

			//Weights = new ObservableCollection<WeightObjectViewModel>
			//{
			//	new WeightObjectViewModel(new Weight(145, DateTime.Now)),
			//	new WeightObjectViewModel(new Weight(140, DateTime.Now)),
			//	new WeightObjectViewModel(new Weight(135, DateTime.Now))
			//};

			Weights = new ObservableCollection<WeightObjectViewModel>();

			Labels = new List<string>();

			Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Foo",
					Values = new ChartValues<double>()
				}
			};

			Labels.AddRange(Weights.Select(weight => weight.Date));

			Series[0].Values = new ChartValues<double>(Weights.Select(weight => weight.WeightNum));
			
			AddWeight = new AddWeightCommand(this);
		}

        public void UpdateChart()
        {
            Series[0].Values = new ChartValues<double>(Weights.Select(weight => weight.WeightNum));
            Labels.Clear();
            Labels.AddRange(Weights.Select(weight => weight.Date));
        }
    }
}
