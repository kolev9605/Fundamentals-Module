using System;
using System.Collections.Generic;

class Palindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ', ',', '?', '!', '.');

        List<string> palindromes = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            char[] word = input[i].ToCharArray();
            char[] reversedWord = input[i].ToCharArray();
            Array.Reverse(reversedWord);
            bool match = false;
            for (int j = 0; j < word.Length; j++)
            {
                if (!word[j].Equals(reversedWord[j]))
                {
                    match = false;
                    continue;
                }
                else
                {
                    match = true;
                }
            }
            if (match)
            {
                string transformedWord = String.Join("", word);
                palindromes.Add(transformedWord);
            }
        }
        Console.WriteLine(string.Join(", ",palindromes));
    }
}