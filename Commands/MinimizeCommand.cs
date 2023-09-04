using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WeightLog.ViewModels;

namespace WeightLog.Commands
{
    public class MinimizeCommand : CommandBase
    {
        
        public override void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
            }
        }

        public MinimizeCommand()
        {

        }
    }
}
