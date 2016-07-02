using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string pattern = (@"(.)\1+");
        Regex regex = new Regex(pattern);
        Console.WriteLine(regex.Replace(text, "$1"));
    }
}

