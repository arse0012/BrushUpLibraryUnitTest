using System;

namespace BrushUpLibrary
{
    public class Person2
    {
        private string _name;
        private string _address;

        public enum GenderType { male, female}

        public string Name
        {
            get => _name;
            set
            {
                if(value == null)throw new ArgumentNullException();
                if (value.Length < 2) throw new ArgumentException();
                _name = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (value != null) _address = value;
                else throw new ArgumentNullException();
            }
        }

        public GenderType Gender { get; set; }

        public override string ToString()
        {
            return Name + " " + Address;
        }
    }
}