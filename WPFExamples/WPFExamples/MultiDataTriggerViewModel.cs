using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExamples
{
    public class MultiDataTriggerViewModel : INotifyPropertyChanged
    {
        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                OnPropertyChanged(nameof(IsChecked));
            }
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged(nameof(IsEnabled));
            }
        }
        private bool _isCheckedCheckbox = false;

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
                        IsEnabled = true;
                        IsChecked = true;
                    }
                    else
                    {
                        // Do something when CheckBox is unchecked
                        IsEnabled = false;
                        IsChecked = false;
                    }
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
