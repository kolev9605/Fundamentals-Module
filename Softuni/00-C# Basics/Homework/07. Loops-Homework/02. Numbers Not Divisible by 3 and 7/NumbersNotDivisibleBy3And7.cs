using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int counter = 1;

        while (counter<=number)
        {
            if (counter%7!=0&&counter%3!=0)
            {
                Console.Write(counter+" ");
            }
            counter++;
        }
        Console.WriteLine();
    }
}

