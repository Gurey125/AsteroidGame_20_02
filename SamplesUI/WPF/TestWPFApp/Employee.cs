using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPFApp
{
    class Employee : INotifyPropertyChanged
    {
        private string name;
        private string department;

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }

        public string Name 
        { 
            get => name;
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public string Department 
        { 
            get => department;
            set
            {
                department = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Department)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return $" {Name} {Department} ";
        }
    }
}
