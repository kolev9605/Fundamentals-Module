using System;

class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 2; i < number; i++ )
        {
            if (number%i==0)
            {
                count++;
            }
        }

        bool isPrime = (count == 0&&number>0);
        Console.WriteLine(isPrime);

    }
}

