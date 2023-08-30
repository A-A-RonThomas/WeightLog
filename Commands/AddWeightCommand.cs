using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.Models;
using WeightLog.ViewModels;

namespace WeightLog.Commands
{
    public class AddWeightCommand : CommandBase
    {
        private readonly ObservableCollection<WeightObjectViewModel> _weightObjects;
        private readonly WeightList _weightList;

        public AddWeightCommand(WeightList weightList, ObservableCollection<WeightObjectViewModel> obWeightList)
        {
            _weightList = weightList;
            _weightObjects = obWeightList;
        }

        public override void Execute(object? parameter)
        {
            Weight weight = new Weight(245, DateTime.Now);

            _weightList.addWeight(weight);
            _weightObjects.Add(new WeightObjectViewModel(weight));
        }
    }
}
