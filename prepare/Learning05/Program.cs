using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Purple", 2);
        // Console.WriteLine($"Square Area: {square1.GetArea()}");
        // Console.WriteLine($"Square Color: {square1.GetColor()}");
        shapes.Add(square1);

        Circle circle1 = new Circle("Blue", 3);
        // Console.WriteLine($"Square Area: {circle1.GetArea()}");
        // Console.WriteLine($"Square Color: {circle1.GetColor()}");
        shapes.Add(circle1);

        Rectangle rectangle1 = new Rectangle("Purple", 4, 5);
        // Console.WriteLine($"Square Area: {rectangle1.GetArea()}");
        // Console.WriteLine($"Square Color: {rectangle1.GetColor()}");
        shapes.Add(rectangle1);

        foreach (Shape s in shapes)
        {
            string Color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {Color} shape has an area of {area}.");
        }
    }
}