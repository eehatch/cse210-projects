public class Activity
{
    private string _name;
    private int _duration;
    private string _welcomeMessage;
    // private string _endMessage;

    public Activity(string Name, string WelcomeMessage)
    {
        _name = Name;
        _welcomeMessage = WelcomeMessage;
    }  
    public void DisplayStartingMessage()
    {
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Your session 0f " + _duration + " seconds has ended.");
        Console.WriteLine("Thank you for your time!");
    }
    public void Countdown()
    {
        List<string> animationString = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };
        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime spinner = startTime.AddSeconds(_duration);
        Thread.Sleep(3000);
        Console.WriteLine("Get Ready...");
        while (DateTime.Now < spinner)
        {
            string  s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
    public string Intro()
    {
        return $"{_name}\n{_welcomeMessage}";
        // also wrong
    }
}