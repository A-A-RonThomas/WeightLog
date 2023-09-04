using WeightLog.Models;

namespace WeightLog.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; set; }

        public MainViewModel(WeightList weightList)
        {
            CurrentViewModel = new WeightViewModel(weightList);
        }
    }
}
