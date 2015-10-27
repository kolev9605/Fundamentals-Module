using System;

class SumOf5Numbers
{
    static void Main()
    {
        string[] userINput = Console.ReadLine().Split();
        double a = Convert.ToInt32(userINput[0]);
        double b = Convert.ToInt32(userINput[1]);
        double c = Convert.ToInt32(userINput[2]);
        double d = Convert.ToInt32(userINput[3]);
        double e = Convert.ToInt32(userINput[4]);
        double sumOfAll = a + b + c + d + e;
        Console.WriteLine(sumOfAll);
    }
}

