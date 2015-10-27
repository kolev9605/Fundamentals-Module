using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        int bit = (number >> position) & 1;
        Console.WriteLine(bit);
    }
}

