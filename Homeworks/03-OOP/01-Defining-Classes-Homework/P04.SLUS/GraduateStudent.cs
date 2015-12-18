using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.SLUS
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, int age, string studentNumber, double averageGrage) 
            : base(firstName, lastName, age, studentNumber, averageGrage)
        {

        }
    }
}
