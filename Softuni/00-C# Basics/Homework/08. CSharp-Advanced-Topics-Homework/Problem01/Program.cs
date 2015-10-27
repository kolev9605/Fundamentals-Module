using System;

class Program
{
    static void Fib(int n)
    {
        int n1 = 0; int n2 = 1; int nextNumber = 0;
        for (int i = 1; i <= n; i++)
        {
            nextNumber = n1 + n2;
            n1 = n2;
            n2 = nextNumber;

        }
        Console.WriteLine(nextNumber);
    }
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Fib(number);
    }
}

