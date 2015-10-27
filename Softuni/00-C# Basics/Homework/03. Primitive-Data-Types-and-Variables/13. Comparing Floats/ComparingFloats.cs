using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;

        double realNumber1 = double.Parse(Console.ReadLine());
        double realNumber2 = double.Parse(Console.ReadLine());

        bool areEqual;

        areEqual = (((Math.Max(realNumber1,  realNumber2)) - (Math.Min(realNumber1,realNumber2)))<=eps);
        Console.WriteLine(areEqual);

    }
}
