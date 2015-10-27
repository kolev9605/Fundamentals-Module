using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= number)
        {
            Console.Write(counter + " ");
            counter += 1;
        }
        Console.WriteLine();
    }
}