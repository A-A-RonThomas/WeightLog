using System;
using System.Windows.Input;
using WeightLog.Commands;

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
				Date = _selectedDate.ToString("M");
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

		public NewWeightViewModel(WeightViewModel callingViewModel)
		{
			SelectedDate = DateTime.Now;
			Date = DateTime.Now.ToString("M");

			Add = new SubmitNewWeightCommand(this, callingViewModel);
			Cancel = new CancelCommand();
		}
	}
}
