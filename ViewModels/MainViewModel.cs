using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;
using WeightLog.Commands;
using WeightLog.Models;

namespace WeightLog.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; set; }

        public ICommand Minimize { get; }
        public ICommand Close { get; }

		public MainViewModel(WeightList weightList)
        {
            CurrentViewModel = new WeightViewModel(weightList);



            Minimize = new MinimizeCommand();
            Close = new CloseCommand();
        }
    }
}
