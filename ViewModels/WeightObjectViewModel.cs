using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.Models;

namespace WeightLog.ViewModels
{
    public class WeightObjectViewModel : ViewModelBase
    {
        private readonly Weight _weight;
        public double WeightNum => _weight.WeightNum;

        public string Date => _weight.Date.ToString("d");

        public double? Percentage => _weight.Percentage;

        public WeightObjectViewModel(Weight weight)
        {
            _weight = weight;
        }

    }
}
