using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class Person
    {
        private int _age;
        private string _fName;
        private string _lName;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be greater than 0");
                }
            }
        }

        public string FName
        {
            get { return _fName; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name is required");
                }
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First Name must be between 2 to 10 characters in length");
                }
            }
        }

        public string LName
        {
            get { return _lName; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last Name is required");
                }
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last Name must be between 3 to 15 characters in length");
                }
            }
        }

        public double Height { get; set; }

        public double Weight { get; set; }
    }
}
