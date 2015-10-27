using System;
using System.Numerics;

namespace ConsoleInputOutput
{
    public static class Fibonachi
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1) Console.WriteLine(0);
            else
            {
                BigInteger first = 0;
                BigInteger second = 1;
                Console.WriteLine(first);
                Console.WriteLine(second);
                BigInteger third = 0;
                for (int i = 2; i < n; i++)
                {
                    third = first + second;
                    Console.Write(third + " ");
                    first = second;
                    second = third;
                }
            }
        }
    }
}