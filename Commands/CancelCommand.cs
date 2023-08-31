using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightLog.ViewModels;

namespace WeightLog.Commands
{
    public class CancelCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                var window = parameter as System.Windows.Window;
                window?.Close();
            }
        }
    }
}
