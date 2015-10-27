using System;

class ExtractBit3
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int bit = (number >> 3) & 1;
        Console.WriteLine(bit);
    }
}

