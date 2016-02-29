using System;
using _02_Animals;

namespace Animals
{
    class Frog : Animal, ISoundProducible
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Kvak-Kvak");
        }
    }
}
