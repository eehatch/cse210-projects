public class Listing : Activity
{
    private string _showPrompt;
    private string _userEntries;
    private int _countUserEntries;


    public Listing(string ShowPrompt, string UserEntires, int CountUserEntries, string StartMessage, int Duration): base(StartMessage, Duration)
    {
        _showPrompt = ShowPrompt;
        _userEntries = UserEntires;
        _countUserEntries = CountUserEntries;
    }

    public override void StartMessage()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }
    public string GetList()
    {   
        return _userEntries;
    }

    public string GetPrompt()
    {
        return _showPrompt;
    }

    public int GetEntiresNumber()
    {
        return _countUserEntries;
    }

}