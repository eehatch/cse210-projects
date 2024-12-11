public class Reception : Event
{
    private string _register;

    public Reception(string Register, string Title, string Description, string date, string time, string Address) : base(Title, Description, date, time, Address)
    {
        _register = Register;
    }
    public string GetEmail()
    {
        return _register;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nPlease RSVP at {_register}!";
    }
}