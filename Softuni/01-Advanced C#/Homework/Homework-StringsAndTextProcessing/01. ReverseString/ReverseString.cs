using System;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] charArr = input.ToCharArray();
        Array.Reverse(charArr);
        Console.WriteLine(new String(charArr));
    }
}