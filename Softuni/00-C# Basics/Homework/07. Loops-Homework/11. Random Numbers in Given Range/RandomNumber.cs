using System;

class RandomNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minValue = int.Parse(Console.ReadLine());
        int maxValue = int.Parse(Console.ReadLine());
        Random randomGen = new Random();

        for (int i = 0; i <= n; i++)
        {
            int randomValue = randomGen.Next(minValue, maxValue+1);
            Console.Write(randomValue + " ");
        }
        Console.WriteLine();
    }
}

