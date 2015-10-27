using System;

class Program
{
    static void PrimeCheck(long n)
    {
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(n);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (n % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        if (n<=1)
        {
            prime = false;
        }
        Console.WriteLine(prime);

    }

    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        PrimeCheck(number);
    }
}

