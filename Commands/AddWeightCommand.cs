using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.Models;

namespace WeightLog.Commands
{
    public class AddWeightCommand : CommandBase
    {
        private readonly WeightList _weightList;

        public AddWeightCommand(WeightList weightList)
        {
            _weightList = weightList;
        }

        public override void Execute(object? parameter)
        {
            
        }
    }
}
