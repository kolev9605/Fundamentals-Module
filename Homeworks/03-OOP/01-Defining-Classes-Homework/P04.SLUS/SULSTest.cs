using System;
using System.Linq;

using System.Collections.Generic;

namespace P04.SLUS
{
    class SULSTest
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();

            peopleList.Add(new SeniorTrainer("Edu", "Edu", 20));
            peopleList.Add(new CurrentStudent("Georgi", "Kolev", 19, "213213213213",5.00, "OOP"));
            peopleList.Add(new Person("pesho", "peshev", 22));
            peopleList.Add(new CurrentStudent("Ivo", "Ivov", 12, "12321321", 3.33, "JS"));
            peopleList.Add(new Trainer("Svetlin", "Nakov", 35));
            peopleList.Add(new CurrentStudent("Kaval", "Siderov", 12, "12321321", 2.00, "JS"));


            peopleList.OfType<CurrentStudent>()
                .OrderByDescending(x => x.AverageGrade)
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}