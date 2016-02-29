using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance_And_Abstraction_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("gosho", "gosho", "sad213sad"));
            students.Add(new Student("sasho", "sasho", "sad2dsag"));
            students.Add(new Student("petar", "petar", "13sf3fd"));
            students.Add(new Student("evgeni", "evgeni", "3dsf4fg"));
            students.Add(new Student("nasko", "nasko", "3dxgre4"));
            students.Add(new Student("yoan", "yoan", "3dsg4g"));
            students.Add(new Student("stefan", "stefan", "ynhyh6h"));
            students.Add(new Student("kiro", "kiro", "59reg65"));
            students.Add(new Student("asen", "asen", "23090hf"));
            students.Add(new Student("ilko", "ilko", "gfslfdy5"));

            students
                .OrderBy(x => x.FacultyNumber)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("gosho", "gosho", 200, 8));
            workers.Add(new Worker("sasho", "sasho", 500, 10));
            workers.Add(new Worker("petar", "petar", 300, 12));
            workers.Add(new Worker("evgeni", "evgeni", 100, 5));
            workers.Add(new Worker("nasko", "nasko", 700, 8));
            workers.Add(new Worker("yoan", "yoan", 440, 9));
            workers.Add(new Worker("stefan", "stefan", 255, 8));
            workers.Add(new Worker("kiro", "kiro", 234, 4));
            workers.Add(new Worker("asen", "asen", 325, 7));
            workers.Add(new Worker("ilko", "ilko", 600, 12));

            workers
                .OrderByDescending(x => x.MoneyPerHour(x.WeekSalary, x.WorkHoursPerDay))
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            var finalList = new List<Human>();
            finalList.AddRange(students);
            finalList.AddRange(workers);
            Console.WriteLine();
            finalList
                .OrderBy(x => x.FirstName)
                .ThenBy(x=>x.FirstName)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
