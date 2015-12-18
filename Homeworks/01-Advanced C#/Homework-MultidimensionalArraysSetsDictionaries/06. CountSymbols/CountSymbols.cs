using System;

class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] inputParts = input.ToCharArray();
        Array.Sort(inputParts);
        int evenCounter = 1;

        for (int i = 0; i < inputParts.Length-1; i++)
        {
            if (inputParts[i]==inputParts[i+1])
            {
                evenCounter++;
            }
            else
            {
                Console.WriteLine("{0}: {1} times", (char)inputParts[i], evenCounter);
                evenCounter = 1;
            }
        }
    }
}

