public class Lecture : Event
{
    private int _capacity;
    private string _speakerName;

    public Lecture(int Capacity, string SpeakerName, string Title, string Description, string date, string time, string Address) : base(Title, Description, date, time, Address)
    {
        _capacity = Capacity;
        _speakerName = SpeakerName;
    }

    public int GetCapacity()
    {
        return _capacity;
    }
    public string SpeakerName()
    {
        return _speakerName;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nThe Speaker will be {_speakerName}!";

    }
}