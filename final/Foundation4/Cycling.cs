public class Cycling : Activity
{
    private double _speed;

    public Cycling(double Speed, string Date, double Length) : base(Date, Length)
    {
        _speed = Speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return GetLength() * GetSpeed();
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}