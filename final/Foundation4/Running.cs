public class Running : Activity
{
    private double _distance;

    public Running(double Distance, string Date, double Length) : base(Date, Length)
    {
        _distance = Distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / GetLength() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}