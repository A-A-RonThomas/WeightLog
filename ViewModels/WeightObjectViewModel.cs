using LiveCharts;
using LiveCharts.Definitions.Series;
using LiveCharts.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.Models;

namespace WeightLog.ViewModels
{
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

        private double? _percentage;

        public double? Percentage
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
    }
}
