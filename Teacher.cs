using System;

namespace BrushUpLibrary
{
    public class Teacher : Person
    {

        private int _salary;

        public int Salary
        {
            get => _salary;
            set
            {
                if (value >= 0) _salary = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + Salary;
        }
    }
}
