using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime myDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(myDate.ToString("hh:mm tt"));


    }
}