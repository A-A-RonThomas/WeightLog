using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.ViewModels;

namespace WeightLog.Commands
{
    public class DateChosenCommand : CommandBase
    {
        private readonly NewWeightViewModel _newWeightViewModel;

        public override void Execute(object? parameter)
        {
            _newWeightViewModel.Date = _newWeightViewModel.SelectedDate.ToString("M");
        }

        public DateChosenCommand(NewWeightViewModel newWeightViewModel) 
        {
            _newWeightViewModel = newWeightViewModel;
        }
    }
}
