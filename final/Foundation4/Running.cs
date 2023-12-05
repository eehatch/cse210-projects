public class Running : Activity
{
    private int _distance;

    public Running(int Distance, string Date, int Length) : base(Date, Length)
    {
        _distance = Distance;
    }

    public override int GetPace()
    {
        return _distance / Time * 60;
    }
}