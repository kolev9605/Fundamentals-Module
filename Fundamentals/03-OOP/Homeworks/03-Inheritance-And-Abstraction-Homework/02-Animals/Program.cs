using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pesho = new Dog("Pesho", 19, "male");
            Cat tom = new Tomcat("Tommy", 12);
            Dog koche = new Dog("Koche", 10, "male");

            List<Animal> animals = new List<Animal>();

            animals.Add(pesho);
            animals.Add(tom);
            animals.Add(koche);

            animals.OrderBy(x=>x.Name).ToList().ForEach(Console.WriteLine);

            koche.ProduceSound();
            (pesho as Dog).ProduceSound();
            tom.ProduceSound();
        }
    }
}
