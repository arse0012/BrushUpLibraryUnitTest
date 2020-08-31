using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUpLibrary
{
    public class Teacher
    {
        private string _name;
        private string _address;
        private int _salary;
        public enum GenderType { male, female}

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 1) _name = value;
                else throw new ArgumentException();
            }
        }
        public string Address
        {
            get => _address;
            set
            {
                if (value != null) _address = value;
                else throw new ArgumentException();
            }
        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value < 0) _salary = value;
                else throw new ArgumentException();
            }
        }
        public GenderType Gender { get; set; }
    }
}
