using System;

class NumberComparer
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number from {0} and {1} is: {2}", number1, number2, Math.Max(number1, number2));
    }
}

