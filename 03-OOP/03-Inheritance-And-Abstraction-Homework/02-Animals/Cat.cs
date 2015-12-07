using System;
using _02_Animals;

namespace Animals
{
    class Cat : Animal, ISoundProducible
    {
        public void ProduceSound()
        {
            Console.WriteLine("Mqlo");
        }

        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
        }
    }
}
