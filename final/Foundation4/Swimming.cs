using System.Reflection.Metadata.Ecma335;

public class Swimming : Activity
{
    private double _numberLaps;
    public Swimming(double NumberLaps, string Date, double Length) : base(Date, Length)
    {
        _numberLaps = NumberLaps;
    }
    public override double GetDistance()
    {
        return _numberLaps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return  GetDistance() / GetLength() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}