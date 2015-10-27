using System;

class SumOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("The sum of {0}, {1} and {2} is {3}.",a,b,c,sum);
    }
}

