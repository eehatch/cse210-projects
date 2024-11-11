using System.Diagnostics;

public class Listing :Activity
{
    private List<Activity> _prompt = new();
    private int _entryCounter;

    public Listing(string Name, string WelcomeMessage) : base(Name, WelcomeMessage)
    {
    }

    public int DisplayCount()
    {
        return _entryCounter;
    }
    public void List()
    {
        
    }
}