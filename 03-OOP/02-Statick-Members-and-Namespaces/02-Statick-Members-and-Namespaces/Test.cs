using _02_Statick_Members_and_Namespaces;
using System;
using System.Collections.Generic;

namespace Points
{
    class Test
    {
        static void Main(string[] args)
        {
            //Probmel 1
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Problem 1 test:");
            Console.WriteLine(new string('-', 10));
            Point3D p1 = new Point3D(1, 2, 34);
            Console.WriteLine(p1);
            Console.WriteLine(Point3D.StartingPoint);
            Point3D p2 = new Point3D(23, 231, 4);

            //Problem 2
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Problem 2 test:");
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(DistanceCalculator.CalcDistance(p1, p2));

            //Problem 3
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Problem 3 test:");
            Console.WriteLine(new string('-', 10));
            List<Point3D> listOfPoints = new List<Point3D> { p1, p2 };
            Path3D path = new Path3D(listOfPoints);
            path.AddPoint(new Point3D(2, 234, 4));
            Console.WriteLine(path);

            Storage.Write(path);
            Storage.Read();
        }
    }
}
