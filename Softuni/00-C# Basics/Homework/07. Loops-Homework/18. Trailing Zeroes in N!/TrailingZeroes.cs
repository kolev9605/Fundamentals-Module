using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now);
        int number = int.Parse(Console.ReadLine());
        BigInteger fact=1;
        for (int i = 2; i <= number; i++)
        {
            fact *= i;
        }
        int count = 0;
        Console.WriteLine(DateTime.Now);
        while (fact%10==0)
        {
            count++;
            fact /= 10;
        }
        Console.WriteLine(fact);
        Console.WriteLine(count);
        
    }
}

