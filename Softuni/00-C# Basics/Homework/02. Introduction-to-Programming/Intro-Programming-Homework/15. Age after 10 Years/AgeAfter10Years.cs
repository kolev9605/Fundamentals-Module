using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("How old are you?: ");
        int yearsOld = int.Parse(Console.ReadLine());
        Console.WriteLine("Now you are {0} years old, but you will be {1} after 10 years :(", yearsOld, yearsOld+10);
    }
}

