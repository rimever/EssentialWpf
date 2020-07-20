using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Chapter6_19
{
    public class Person:INotifyPropertyChanged
    {
        public Name Name { get; set; } = new Name(string.Empty,string.Empty);
        private IList<Address> _addresses = new ObservableCollection<Address>();

        public IList<Address> Addresses
        {
            get => _addresses;
            set
            {
                _addresses = value;
                NotifyChanged("First");
            }
        }

        private void NotifyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Person(Name name)
        {
            Name = name;
        }
    }

    public class Address
    {
        public string AddressName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
    }

    public class Name : INotifyPropertyChanged
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

        public string Full => First + " " + Last;

        private void NotifyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public Name(string first,string last)
        {
            First = first;
            Last = last;
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
