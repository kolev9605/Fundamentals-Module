using System;

class CalculateSomething
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        int fact = 1;
        double powered = 1;

        for (int i = 1; i <=n ; i++)
        {
            fact *= i;
            powered = Math.Pow(x, i);
            sum += fact/powered;
        }
        Console.WriteLine("Sum = {0:F5}",sum);
    }
}

