public class Cycling : Activity
{
    private int _speed;

    public Cycling(int Speed, string Date, int Length) : base(Date, Length)
    {
        _speed = Speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}