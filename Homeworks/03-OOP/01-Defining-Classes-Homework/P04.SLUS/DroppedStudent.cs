using System;

namespace P04.SLUS
{
    class DroppedStudent : Student
    {
        public DroppedStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string dropReason) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropReason = dropReason;
        }
        private string dropReason;

        public string DropReason
        {
            get { return this.dropReason; }
            set { this.dropReason = value; }
        }

        public void Reaply()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}: {5}",
                this.FirstName,
                this.LastName,
                this.Age,
                this.StudentNumber,
                this.AverageGrade,
                this.DropReason);
        }
    }
}
