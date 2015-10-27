using System;

class CountSubstringOccurrences
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().ToLower();
        string partToCompare = Console.ReadLine().ToLower();
        int matchCount = 0;
        bool match = false;
        char[] partToCompareToArr = partToCompare.ToCharArray();
        for (int i = 0; i < input.Length-partToCompare.Length+1; i++)
        {
            char[] currentSubstring = (input.Substring(i,partToCompare.Length)).ToCharArray();
            for (int j = 0; j < currentSubstring.Length; j++)
            {
                if (partToCompareToArr[j].Equals(currentSubstring[j]))
                {
                    match = true;
                }
                else
                {
                    match = false;
                    break;
                }
            }
            if (match==true)
            {
                matchCount++;
            }
        }
        Console.WriteLine(matchCount);
    }
}