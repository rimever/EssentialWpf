using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chapter6_9
{
    class Name : INotifyPropertyChanged
    {
        private string _first;
        private string _last;

        public string First
        {
            get => _first;
            set
            {
                _first = value;
                NotifyChanged("First");
            }
        }

        public string Last
        {
            get => _last;
            set
            {
                _last = value;
                NotifyChanged("Last");
            }
        }

        private void NotifyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
