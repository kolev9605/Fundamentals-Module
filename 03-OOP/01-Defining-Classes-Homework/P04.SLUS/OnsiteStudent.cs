using System;

namespace P04.SLUS
{
    class OnsiteStudent : CurrentStudent
    {
        public OnsiteStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse, int numberVisits) 
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberVisits = numberVisits;
        }
        private int numberVisits;

        public int NumberVisits
        {
            get { return numberVisits; }
            set { numberVisits = value; }
        }

    }
}
