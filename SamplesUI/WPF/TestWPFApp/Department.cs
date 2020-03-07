using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPFApp
{
    class Department : INotifyPropertyChanged
    {
        private string name;

        public Department(string name)
        {
            Name = name;
        }

        public string Name 
        { 
            get => name;
            set
            {
                name = value;
                // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                RaisePropertyChanged(nameof(Name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Name;
        }
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
