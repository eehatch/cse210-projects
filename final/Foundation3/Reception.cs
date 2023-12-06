public class Reception : Event
{
    private string _email;

    public Reception(string Email, string Title, string Description, string date, string time, string Address) : base(Title, Description, date, time, Address)
    {
        _email = Email;
    }
    public string GetEmail()
    {
        return _email;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nPlease RSVP at {_email}!";
    }
}