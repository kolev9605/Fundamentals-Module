using System;

namespace P04.SLUS
{
    class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} course created", courseName);
        }
    }
}
