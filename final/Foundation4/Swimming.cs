public class Swimming : Activity
{
    private double _numberLabs;
    public Swimming(int NumberLabs, string Date, int Length) : base(Date, Length)
    {
        _numberLabs = NumberLabs;
    }

    public override double GetPace()
    {
        return _numberLabs * 50 / 1000 * 0.62;
    }
}