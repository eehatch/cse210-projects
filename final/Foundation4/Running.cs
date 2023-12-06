public class Running : Activity
{
    private int _distance;

    public Running(int Distance, string Date, int Length) : base(Date, Length)
    {
        _distance = Distance;
    }

    public override double GetPace()
    {
        return _distance / GetLength() * 60;
    }
}