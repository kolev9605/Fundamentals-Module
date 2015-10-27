using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string input = Console.ReadLine();
        while (input != "//END_OF_CODE")
        {
            sb.Append(input);
            input = Console.ReadLine();
        }
        string intPattern = @"int ([a-z]\w*)";
        string doublePattern = @"double ([a-z]\w*)";
        Regex intRegex = new Regex(intPattern);
        Regex doubleRegex = new Regex(doublePattern);

        MatchCollection intMatches = intRegex.Matches(sb.ToString());
        MatchCollection doubleMatches = doubleRegex.Matches(sb.ToString());

        List<string> intOutput = new List<string>();
        foreach (Match currentMatch in intMatches)
        {
            intOutput.Add(currentMatch.Groups[1].Value);
        }

        List<string> doubleOutput = new List<string>();
        foreach (Match currentMatch in doubleMatches)
        {
            doubleOutput.Add(currentMatch.Groups[1].Value);
        }

        if (doubleOutput.Count != 0)
        {
            Console.WriteLine("Doubles: " + (string.Join(", ", doubleOutput.OrderBy(x => x))));
        }
        else
        {
            Console.WriteLine("Doubles: None");
        }
        if (intOutput.Count != 0)
        {
            Console.WriteLine("Ints: " + (string.Join(", ", intOutput.OrderBy(x => x))));
        }
        else
        {
            Console.WriteLine("Ints: None");
        }
    }
}