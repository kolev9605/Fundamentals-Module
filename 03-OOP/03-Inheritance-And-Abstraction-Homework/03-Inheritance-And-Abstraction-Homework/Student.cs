using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance_And_Abstraction_Homework
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            :base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length >10)
                {
                    throw new ArgumentOutOfRangeException("Faculty Number must be in range [5-10] digits/letters");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - faculty number: [{2}]",
                this.FirstName,
                this.LastName,
                this.FacultyNumber);
        }
    }
}
