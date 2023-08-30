using LiveCharts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeightLog.Commands;
using WeightLog.Models;

namespace WeightLog.ViewModels
{
    public class WeightViewViewModel : ViewModelBase
    {
		private SeriesCollection series;
		private readonly ObservableCollection<WeightObjectViewModel> _weights;

		public IEnumerable<WeightObjectViewModel> Weights => _weights;
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


		public WeightViewViewModel(WeightList weightList)
		{
			_weights = new ObservableCollection<WeightObjectViewModel>();
			AddWeight = new AddWeightCommand(weightList);
		}
	}
}
