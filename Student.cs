using System;

namespace BrushUpLibrary
{
    public class Student : Person2
    {
        private int _semester;

        public int Semester
        {
            get => _semester;
            set
            {
                if (value >= 1 && value <= 8) _semester = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + Semester;
        }
    }
}
