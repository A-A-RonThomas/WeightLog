using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.Models;

namespace WeightLog.Commands
{
    public class SubmitNewWeightCommand : CommandBase
    {
        private readonly WeightList _weightList;
        private readonly Weight _weight;
        public override void Execute(object? parameter)
        {
            _weightList.addWeight(_weight);
            Debug.WriteLine(_weightList.ToString());
            var window = parameter as System.Windows.Window;
            window?.Close();
        }

        public SubmitNewWeightCommand(WeightList weightList, DateTime date, double weight)
        {
            _weightList = weightList;
            _weight = new Weight(weight, date);
        }
    }
}
