using System;

class Program
{
    static void Main(string[] args)
    {
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] randomArray = new int[lengthOfArray];
        Random random = new Random();
        DateTime start = DateTime.Now;
        for (int i = 0; i < randomArray.Length; i++)
        {
            randomArray[i] = random.Next(1, randomArray.Length + 1);
            for (int j = 0; j < i; j++)
            {
                if (randomArray[i] == randomArray[j])
                {
                    randomArray[i] = random.Next(1, randomArray.Length + 1);
                    j = -1;
                }
            }
            Console.Write(randomArray[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(DateTime.Now - start);
    }
}