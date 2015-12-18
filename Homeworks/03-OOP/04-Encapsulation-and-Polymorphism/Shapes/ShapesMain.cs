using System;
using Shapes.Interfaces;
using Shapes.Shapes;

namespace Shapes
{
    public class ShapesMain
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rhombus rhombus = new Rhombus(5, 2);
            Rectangle rectangle = new Rectangle(2, 10);

            IShape[] shapes = { circle,rhombus,rectangle};

            foreach (var shape in shapes)
            {
                Console.WriteLine("Area: {0}",shape.CalculateArea());
                Console.WriteLine("Perimeter: {0}", shape.CalculatePerimeter());
            }
        }
    }
}
