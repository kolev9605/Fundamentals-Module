using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());

        int firstSetBits = (number >> p) & ((int)Math.Pow(2, k) - 1);
        int secondSetBits = (number >> q) & ((int)Math.Pow(2, k) - 1);

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(firstSetBits, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(secondSetBits, 2).PadLeft(32, '0'));

        // nullify first bits
        number = number & ((~7 << p) | ((int)Math.Pow(2, p) - 1));
        // nullify second bits
        number = number & ((~7 << q) | ((int)Math.Pow(2, q) - 1));

        number = number | secondSetBits << p | firstSetBits << q;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(number);
    }
}