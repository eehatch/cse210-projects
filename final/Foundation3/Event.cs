public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string Title, string Description, string date, string time, string Address)
    {
        _title = Title;
        _description = Description;
        _date = date;
        _time = time;
        _address = Address;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetTime()
    {
        return _time;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetAddress()
    {
        return _address;
    }
    public virtual string GetStandardDetails()
    {
        return $"\n{_title}: {_description} This event takes place on {_date} @ {_time} - {_address}";
    }
    public virtual string GetShortDescription()
    {
        return $"\n{this.GetType()}: {_title}! {_description}";
    }
    public abstract string GetFullDetails();
}