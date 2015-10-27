using System;
using System.Collections.Generic;

class Program
{
    static void PrimeInRange(int start, int end, List<int> numbers)
    {
        
        for (int i = start; i <= end; i++)
        {
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(i);
            bool prime = true;
            while (divider <= maxDivider)
            {
                if (i % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            if (i <= 1)
            {
                prime = false;
            }
            if (prime)
            {
                numbers.Add(i);
            }
        }
    }
    static void Main()
    {
        List<int> numbers = new List<int>();
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        PrimeInRange(start, end, numbers);
        foreach (var VARIABLE in numbers)
        {
            Console.WriteLine(VARIABLE);
        }
    }

}

