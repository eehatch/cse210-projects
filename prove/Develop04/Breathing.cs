public class Breathing : Activity
{
    private string _breatheMessage;

    public Breathing(string Name, string WelcomeMessage) : base(Name, WelcomeMessage)
    {
        _breatheMessage = "Welcome to the Breathing Activity";
    }
    public void Breathe()
    {
        //everything goes here
        Console.WriteLine();
        Console.WriteLine(_breatheMessage);
        Console.WriteLine();
        DisplayStartingMessage();
        Countdown();
        DisplayEndMessage(); //end with the end message
    }
}