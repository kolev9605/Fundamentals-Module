using System;

class PointInCircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int radius = 2;

        bool insideCircle = (x*x+y*y<=radius*radius);

        Console.WriteLine(insideCircle);
    }
}

