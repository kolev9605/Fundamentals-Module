using System;
using System.Collections.Generic;

class LongestIncreasingSequence
{
    static void Main()
    {
        string arrayAsString = Console.ReadLine();
        string[] arrayParts = arrayAsString.Split(' ');
        int[] array = Array.ConvertAll<string, int>(arrayParts, int.Parse);
        List<List<int>> sequences = new List<List<int>>();
        sequences.Add(new List<int>());
        sequences[sequences.Count - 1].Add(array[0]);
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] < array[i])
            {
                sequences[sequences.Count - 1].Add(array[i]);
            }
            else
            {
                sequences.Add(new List<int>());
                sequences[sequences.Count - 1].Add(array[i]);
            }
        }
        List<int> maxSequence = new List<int>();
        for (int i = 0; i < sequences.Count; i++)
        {
            if (sequences[i].Count > maxSequence.Count)
            {
                maxSequence = sequences[i];
            }
        }
        Console.Write("Longest: ");
        for (int i = 0; i < maxSequence.Count; i++)
        {
            Console.Write("{0} ", maxSequence[i]);
        }
        Console.WriteLine();
    }
}
