using System;

class Circle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double perimeter = Math.PI * r * 2;
        Console.WriteLine("The perimeter of that circle is {0:F2}.", perimeter);
        Console.WriteLine("The area of that circle is {0:F2}.",area);
    }
}

