using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace WPFExamples
{
    public class EventTriggerExampleViewModel : INotifyPropertyChanged
    {
        public ICommand ButtonClickCommand { get; }

        public EventTriggerExampleViewModel()
        {
            ButtonClickCommand = new RelayCommand(ExecuteButtonClick);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void ExecuteButtonClick(object parameter)
        {
            // Your logic for handling the button click event goes here
            MessageBox.Show("Button Clicked!");
        }
    }
}
