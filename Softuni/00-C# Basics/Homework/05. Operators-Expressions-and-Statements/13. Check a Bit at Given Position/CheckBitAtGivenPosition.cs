using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        bool bitChecker = (((1 << position) & number) >> position) == 1;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine(bitChecker);
    }
}

