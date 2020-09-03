using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BrushUpLibrary
{
    public class Teacher:Person2
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
