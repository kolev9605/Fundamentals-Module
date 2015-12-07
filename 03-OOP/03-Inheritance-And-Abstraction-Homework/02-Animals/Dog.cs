using System;
using _02_Animals;

namespace Animals
{
    class Dog : Animal, ISoundProducible
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Balo");
        }
    }
}
