using System;
using System.CodeDom.Compiler;
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
        private readonly NewWeightViewModel _newWeightViewModel;
        private readonly WeightViewModel _weightViewModel;

        public override void Execute(object? parameter)
        {
            // Creates the new weight object
            Weight newWeight = new Weight(double.Parse(_newWeightViewModel.WeightNum), _newWeightViewModel.SelectedDate);
            WeightObjectViewModel weightObj = new WeightObjectViewModel(newWeight);

            if(_weightViewModel.Weights.Count > 0)
            {
                weightObj.Percentage = 
                    ((weightObj.WeightNum - _weightViewModel.Weights[_weightViewModel.Weights.Count - 1].WeightNum) /
                    _weightViewModel.Weights[_weightViewModel.Weights.Count - 1].WeightNum * 100).ToString("F2") + "%";
            }



            //Adds the new weight object to the Weights ObservableCollection
            _weightViewModel.Weights.Add(weightObj);
            _weightViewModel.UpdateChart();
            _weightViewModel.SaveToXml(_weightViewModel.Weights, "data.xml");

            var window = parameter as System.Windows.Window;
            window?.Close();
        }

        public SubmitNewWeightCommand(NewWeightViewModel viewModel, WeightViewModel callingViewModel)
        {
            _newWeightViewModel = viewModel;
            _weightViewModel = callingViewModel;
        }
    }
}
