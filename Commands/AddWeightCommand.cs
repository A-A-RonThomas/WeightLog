using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private readonly WeightList _weightList;
        private readonly ObservableCollection<WeightObjectViewModel> _weightObjects;
        public override void Execute(object? parameter)
        {
            NewWeightView newWeight = new NewWeightView();
            newWeight.DataContext = new NewWeightViewModel(_weightList, _weightObjects);
            newWeight.Show();
        }

        public AddWeightCommand(WeightList weightList, ObservableCollection<WeightObjectViewModel> weightObjects)
        {
            _weightList = weightList;
            _weightObjects = weightObjects;
        }
    }
}
