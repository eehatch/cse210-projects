using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        // Shape s1 = new Shape();    can't do this one
        Circle s2 = new("red", 1.0);
        Rectangle s3 = new("purple", 1.0, 2.0);
        Square s4 = new("blue", 2.5);

        shapes.Add(s2);
        shapes.Add(s3);
        shapes.Add(s4);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}