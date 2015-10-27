using System;

class DecToBin
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        long rest;
        string output= "";
        while (input!=0)
        {
            rest = input % 2;
            input /= 2;

            output = Convert.ToString(rest) + output;
        }
        Console.WriteLine(output);
    }
}
