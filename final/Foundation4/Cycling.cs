public class Cycling : Activity
{
    private int _speed;

    public Cycling(int Speed, string Date, int Length) : base(Date, Length)
    {
        _speed = Speed;
    }
}