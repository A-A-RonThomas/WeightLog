using System;
using WeightLog.Models;

namespace WeightLog.ViewModels
{
    [Serializable]
    public class WeightObjectViewModel : ViewModelBase
    {
        private readonly Weight _weight;

        private double _weightNum;
        public double WeightNum
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

        private string? _percentage;

        public string? Percentage
        {
            get
            {
                return _percentage;
            }
            set
            {
                _percentage = value;
                OnPropertyChanged(nameof(Percentage));
            }
        }

        public WeightObjectViewModel(Weight weight)
        {
            _weight = weight;
            WeightNum = _weight.WeightNum;
            Date = _weight.Date.ToString("d");
        }

        //Empty Contstructor for the Serializer to XML.
        public WeightObjectViewModel() { }
    }
}
