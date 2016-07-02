using System;

namespace P04.SLUS
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

        public void DeleteCourse(string course)
        {
            Console.WriteLine("{0} course deleated");
        }
    }
}
