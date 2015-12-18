using System;

class UnicodeCharacters
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();
        GetUnicodeValueFromCharArray(input);
    }

    private static void GetUnicodeValueFromCharArray(char[] input)
    {
        foreach (var ch in input)
        {
            Console.Write("\\U{0:X4}", Convert.ToUInt16(ch));
        }
    }
}
