using System;

class Program
{
    static void Main()
    {
        //input
        int count = 1;
        int maxCount = 1;
        int n = int.Parse(Console.ReadLine());
        string[] inputStrings = new String[n];
        string longestSquence="";
        for (int i = 0; i < inputStrings.Length; i++)
        {
            inputStrings[i] = Console.ReadLine();
            
        }
        //count the equala
        for (int i = 1; i < inputStrings.Length; i++)
        {
            if (inputStrings[i] == inputStrings[i-1])
            {
                count++;
                if (maxCount < count)
                {
                    maxCount = count;
                    longestSquence = inputStrings[i];
                }
            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine(maxCount);
        
        //print the equals
        for (int i = 0; i < maxCount; i++)
        {
            Console.WriteLine(longestSquence);
        }
    }
}

