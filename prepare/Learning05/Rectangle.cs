public class Rectangle : Shape
{
    private double _length;
    private double _height;

    public Rectangle(string Color, double Length, double Height) : base (Color)
    {
        _length = Length;
        _height = Height;
    }

    public override double GetArea()
    {
        return _length* _height;
    }
}