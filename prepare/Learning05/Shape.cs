using System.Drawing;
using System.Formats.Asn1;

public abstract class Shape{
    private string _color;
    public Shape(string Color)
    {
        _color = Color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string Color)
    {
        _color = Color;
    }

    public abstract double GetArea();
}