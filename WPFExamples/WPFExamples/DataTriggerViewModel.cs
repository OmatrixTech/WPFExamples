using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFExamples
{
    public class DataTriggerViewModel : INotifyPropertyChanged
    {
        private bool _isButtonEnabled;

        public bool IsButtonEnabled
        {
            get { return _isButtonEnabled; }
            set
            {
                _isButtonEnabled = value;
                OnPropertyChanged();
            }
        }
        private bool _isCheckedCheckbox=false;

        public bool IsCheckedCheckbox
        {
            get { return _isCheckedCheckbox; }
            set
            {
                if (_isCheckedCheckbox != value)
                {
                    _isCheckedCheckbox = value;
                    OnPropertyChanged(nameof(IsCheckedCheckbox));

                    // Call any additional logic here based on the checked state
                    if (_isCheckedCheckbox)
                    {
                        // Do something when CheckBox is checked
                        IsButtonEnabled = true;
                    }
                    else
                    {
                        // Do something when CheckBox is unchecked
                        IsButtonEnabled = false;
                    }
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public DataTriggerViewModel()
        {
            // Initialize the property
            IsButtonEnabled = false;
        }
    }
}
