using System;

class BinToDec
{
    static void Main()
    {
        string binaryInput = Console.ReadLine();
        long convertetBinaryInput = Convert.ToInt64(binaryInput);
        int powerCount = 0;
        long finalNumber = 0;

        while (convertetBinaryInput != 0)
        {
            if (convertetBinaryInput % 10 != 0)
            {
                finalNumber += ((convertetBinaryInput % 10) * (long)Math.Pow(2, powerCount));
            }
            convertetBinaryInput /= 10;
            powerCount++;
        }
        Console.WriteLine(finalNumber);
    }
}

