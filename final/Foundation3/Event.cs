using System.Net.Sockets;
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
    public virtual void GetStandartDetails()
    {
        Console.WriteLine($"{_title}: {_description} on {_date} @ {_time} - {_address}");
    }
    public virtual void GetShortDescription()
    {
        Console.WriteLine($"EVENT TYPE GOES HERE   {_title}: {_description}");
    }
    public abstract string GetFullDetails();
}