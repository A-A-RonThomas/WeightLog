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
    public class NewWeightViewModel : ViewModelBase
    {
		private string _date;
		public string Date
		{
			get
			{
				return _date;
			}
			set
			{
				_date = value;
				OnPropertyChanged(nameof(Date));
			}
		}

		private DateTime _selectedDate;
		public DateTime SelectedDate
		{
			get
			{
				return _selectedDate;
			}
			set
			{
				_selectedDate = value;
				OnPropertyChanged(nameof(SelectedDate));
			}
		}

		private string _weightNum;
		public string WeightNum
		{
			get
			{
				return _weightNum;
			}
			set
			{
				_weightNum = value;
				OnPropertyChanged(nameof(WeightNum));
			}
		}

		public ICommand Add { get; }
		public ICommand Cancel { get; }

		public NewWeightViewModel(WeightList _weightList, ObservableCollection<WeightObjectViewModel> _weightObjects)
		{
			//WeightNum = "0";
			SelectedDate = DateTime.Now;
			Date = DateTime.Now.ToString("M");

			Add = new SubmitNewWeightCommand(this,_weightList, _weightObjects);
			Cancel = new CancelCommand();
		}
	}
}
