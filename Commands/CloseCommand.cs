using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WeightLog.ViewModels;

namespace WeightLog.Commands
{
    public class CloseCommand : CommandBase
    {

        public override void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                MessageBoxResult result = MessageBox.Show("Are You Sure?", "Close?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if(result == MessageBoxResult.Yes)
                {
                    var window = parameter as System.Windows.Window;
                    window?.Close();
                }
            }
        }

    }
}
