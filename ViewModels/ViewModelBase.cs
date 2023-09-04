using System.ComponentModel;
using System.Diagnostics;

namespace WeightLog.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            Debug.WriteLine($"{propertyName} property Changed in {this}!");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
