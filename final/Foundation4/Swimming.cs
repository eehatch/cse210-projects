public class Swimming : Activity
{
    private int _numberLabs;
    public Swimming(int NumberLabs, string Date, int Length) : base(Date, Length)
    {
        _numberLabs = NumberLabs;
    }
}