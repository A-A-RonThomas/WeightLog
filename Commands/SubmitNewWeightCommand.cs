using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

            int index = 0;

            //Figure out where to insert the new weight
            while (index < _weightViewModel.Weights.Count)
            {
                if (DateTime.Parse(weightObj.Date) > DateTime.Parse(_weightViewModel.Weights[index].Date)) index++;
                else
                {
                    break;
                }
            }

            //if the list is empty
            if (_weightViewModel.Weights.Count == 0) _weightViewModel.Weights.Add(weightObj);

            else
            {
                //Place to insert is the beginning and the list is not empty.
                if (index == 0 && _weightViewModel.Weights.Count > 0)
                {
                    weightObj.Percentage = "";
                    _weightViewModel.Weights[index].Percentage =
                        ((_weightViewModel.Weights[index].WeightNum - weightObj.WeightNum) /
                        weightObj.WeightNum * 100).ToString("N2") + "%";

                    _weightViewModel.Weights.Insert(index, weightObj);

                }

                //Place to insert is in the middle of the list, but not the end
                else if (index < _weightViewModel.Weights.Count)
                {
                    weightObj.Percentage =
                        ((weightObj.WeightNum - _weightViewModel.Weights[index - 1].WeightNum) / 
                        _weightViewModel.Weights[index - 1].WeightNum * 100).ToString("N2") + "%";

                    _weightViewModel.Weights[index].Percentage =
                        ((_weightViewModel.Weights[index].WeightNum - weightObj.WeightNum) /
                        weightObj.WeightNum * 100).ToString("N2") + "%";

                    _weightViewModel.Weights.Insert(index, weightObj);

                }

                else
                {
                    weightObj.Percentage =
                        ((weightObj.WeightNum - _weightViewModel.Weights[index - 1].WeightNum) /
                        _weightViewModel.Weights[index - 1].WeightNum * 100).ToString("N2") + "%";

                    _weightViewModel.Weights.Add(weightObj);
                }

            }


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

        public void AddOrdered(WeightObjectViewModel newWeight)
        {
            int index = 0;

            //Figure out where to insert the new weight
            while(index <  _weightViewModel.Weights.Count) 
            {
                if (DateTime.Parse(_weightViewModel.Weights[index++].Date) >= DateTime.Parse(newWeight.Date)) break;
            }

            //Calculate the newWeights percentage, if the newWeight is not being inserted at the end, update the new weights percentage.
            newWeight.Percentage =
                    ((newWeight.WeightNum - _weightViewModel.Weights[index - 1].WeightNum) /
                    _weightViewModel.Weights[index - 1].WeightNum * 100).ToString("F2") + "%";

            if(index !=  _weightViewModel.Weights.Count - 1)
            {
                _weightViewModel.Weights[index].Percentage =
                    ((_weightViewModel.Weights[index - 1].WeightNum - newWeight.WeightNum) /
                    newWeight.WeightNum * 100).ToString("F2") + "%";
            }

            _weightViewModel.Weights.Add(newWeight);
        }

        public void UpdatePercentages(ObservableCollection<WeightObjectViewModel> Weights, WeightObjectViewModel newWeight)
        {

        }
    }
}
