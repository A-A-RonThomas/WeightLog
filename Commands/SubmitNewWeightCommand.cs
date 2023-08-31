using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.Models;
using WeightLog.ViewModels;

namespace WeightLog.Commands
{
    public class SubmitNewWeightCommand : CommandBase
    {
        private readonly WeightList _weightList;
        private readonly NewWeightViewModel _newWeightViewModel;
        private readonly ObservableCollection<WeightObjectViewModel> _weightObjects;
        private Weight weightEntered;
        public override void Execute(object? parameter)
        {
            weightEntered = new Weight(double.Parse(_newWeightViewModel.WeightNum), _newWeightViewModel.SelectedDate);
            _weightList.addWeight(weightEntered);
            
            _weightObjects.Add(new WeightObjectViewModel(weightEntered));
            Debug.WriteLine(_weightList.ToString());

            var window = parameter as System.Windows.Window;
            window?.Close();
        }

        public SubmitNewWeightCommand(NewWeightViewModel viewModel, WeightList weightList,
            ObservableCollection<WeightObjectViewModel> weightObjects)
        {
            _weightList = weightList;
            _newWeightViewModel = viewModel;
            _weightObjects = weightObjects;
        }
    }
}
