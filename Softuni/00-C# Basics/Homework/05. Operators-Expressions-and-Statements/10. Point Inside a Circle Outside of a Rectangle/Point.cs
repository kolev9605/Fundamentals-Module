using System;

class Point
{
    static void Main()
    {
        //(x - center_x)^2 + (y - center_y)^2 < radius^2

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double radius = 1.5;
        double centerX = 1.0;
        double centerY = 1.0;

        double xFormula = Math.Pow((x - centerX), 2);
        double yFormula = Math.Pow((y - centerY), 2);

        bool inCircle = (xFormula + yFormula < radius * radius);
        bool outRectangle = ((x < -1) || (x > 5)) || ((y > 1) || (y < -1));

        Console.WriteLine(inCircle);
        Console.WriteLine(outRectangle);

        if (inCircle==true&&outRectangle==true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

