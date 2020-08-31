using System;

namespace BrushUpLibrary
{
    public class Student
    {
        private string _name;
        private string _address;
        private int _semester;
        public enum GenderType { male, female}

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2) _name = value;
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

        public int Semester
        {
            get => _semester;
            set
            {
                if (value < 1 && value > 8) _semester = value;
                else throw new ArgumentException();
            }
        }
        public GenderType Gender { get; set; }
    }
}
