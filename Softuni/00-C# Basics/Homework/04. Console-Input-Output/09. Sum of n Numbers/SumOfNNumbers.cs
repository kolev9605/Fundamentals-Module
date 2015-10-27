using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter {0}-th number: ", i);
            int num = int.Parse(Console.ReadLine());
            sum = sum + num;
        }
        Console.WriteLine("Sum = {0}.", sum);
    }
}
