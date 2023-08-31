using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeightLog.Commands;
using WeightLog.Models;

namespace WeightLog.ViewModels
{
    public class WeightViewModel : ViewModelBase
    {
		//private readonly WeightList _weightList;
		public CartesianMapper<WeightObjectViewModel> Mapper { get; set; }

		public IEnumerable<WeightObjectViewModel> Weights => _weights;

		private ObservableCollection<WeightObjectViewModel> _weights;

		private SeriesCollection series;
		public SeriesCollection Series
		{
			get
			{
				return series;
			}
			set
			{
				series = value;
				OnPropertyChanged(nameof(Series));
			}
		}

		private LineSeries _line;
		public LineSeries Line
		{
			get
			{
				return _line;
			}
			set
			{
				_line = value;
				OnPropertyChanged(nameof(Line));
			}
		}

		private DateTime date;
		public DateTime Date
		{
			get
			{
				return date;
			}
			set
			{
				date = value;
				OnPropertyChanged(nameof(Date));
			}
		}

		private double weight;
		public double Weight
		{
			get
			{
				return weight;
			}
			set
			{
				weight = value;
				OnPropertyChanged(nameof(Weight));
			}
		}

		private double percentage;
		public double Percentage
		{
			get
			{
				return percentage;
			}
			set
			{
				percentage = value;
				OnPropertyChanged(nameof(Percentage));
			}
		}


		public ICommand AddWeight { get; }


		public WeightViewModel(WeightList weightList)
		{
			_weights = new ObservableCollection<WeightObjectViewModel>();

			Mapper = Mappers.Xy<WeightObjectViewModel>()
				.Y(elem => elem.WeightNum);

			Line = new LineSeries();
			
			AddWeight = new AddWeightCommand(weightList, _weights);

		}
	}
}
