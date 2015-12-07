using System;

namespace P04.SLUS
{
    class Student : Person
    {
        public Student(string firstName, string lastName, int age, string studentNumber, double averageGrade) : base(firstName, lastName, age)
        {
            this.AverageGrade = averageGrade;
            this.StudentNumber = studentNumber;
        }

        private string studentNumber;
        private double averageGrade;

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set
            {
                if (value < 2.0 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Average grade must be in range [2.00 - 6.00]");
                }
                this.averageGrade = value;
            }
        }
        public string StudentNumber
        {
            get { return studentNumber; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Student number must not be null");
                }
                studentNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, average grade: {1:F2}, {2}",
                base.ToString(),
                AverageGrade,
                StudentNumber);
        }
    }
}
