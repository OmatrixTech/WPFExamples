using System.ComponentModel;
using System.Windows.Input;


namespace WPFExamples
{
    public class PropertyTriggerViewModel : INotifyPropertyChanged
    {
      

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
