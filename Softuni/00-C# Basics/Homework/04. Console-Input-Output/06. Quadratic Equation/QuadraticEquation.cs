using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double d = (b*b)-(4*a*c);
        double x1 = (-b + Math.Sqrt(d))/2;
        double x2 = (-b - Math.Sqrt(d))/2;

        Console.WriteLine("x1={0}\t\nx2={1}",x1,x2);
    }
}

