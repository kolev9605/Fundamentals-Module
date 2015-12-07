using System;

namespace P04.SLUS
{
    class CurrentStudent : Student
    {
        public CurrentStudent(string firstName, string lastName, int age, string studentNumber, double averageGrage, string currCourse) 
            : base(firstName, lastName, age, studentNumber, averageGrage)
        {
            this.CurrentCourse = currCourse;
        }
        private string currentCourse;

        public string CurrentCourse
        {
            get { return currentCourse; }
            set { currentCourse = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " " + CurrentCourse;
        }
    }
}
