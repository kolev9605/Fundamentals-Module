using System;

class BitsExchange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int firstSetBits = (number >> 3) & 7;
        int secondSetBits = (number >> 24) & 7;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(firstSetBits, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(secondSetBits, 2).PadLeft(32, '0'));

        // nullify first bits
        number = number & ((~7 << 3) | ((int)Math.Pow(2, 3) - 1));
        // nullify second bits
        number = number & ((~7 << 24) | ((int)Math.Pow(2, 24) - 1));

        number = number | secondSetBits << 3 | firstSetBits << 24;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(number);
    }
}

