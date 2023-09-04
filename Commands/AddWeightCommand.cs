using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.Models;
using WeightLog.ViewModels;
using WeightLog.Views;

namespace WeightLog.Commands
{
    public class AddWeightCommand : CommandBase
    {
        private WeightViewModel weightViewModel;

        public override void Execute(object? parameter)
        {
            NewWeightView newWeight = new NewWeightView();
            newWeight.DataContext = new NewWeightViewModel(weightViewModel);
            newWeight.Show();
        }

        public AddWeightCommand(WeightViewModel viewModel)
        {
            weightViewModel = viewModel;
        }
    }
}
