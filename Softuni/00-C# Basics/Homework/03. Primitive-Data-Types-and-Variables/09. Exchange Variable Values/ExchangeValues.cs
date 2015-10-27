using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int swap;

        Console.WriteLine("a = {0}; b = {1}.",a,b);

        swap = a;
        a = b;
        b = swap;

        Console.WriteLine("a = {0}; b = {1}.", a, b);
    }
}

