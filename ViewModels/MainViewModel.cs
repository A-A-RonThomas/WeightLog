using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.Models;

namespace WeightLog.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(WeightList weightList)
        {
            CurrentViewModel = new WeightViewViewModel(weightList);
        }
    }
}
