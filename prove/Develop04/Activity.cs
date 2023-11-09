public class Activity
{
    public string _startMessage; 
    protected int _duration;

    public Activity(string StartMessage, int Duration)
    {
        _duration = Duration;
        _startMessage = StartMessage;
    }
    public virtual void StartMessage()
    {
        Console.WriteLine($"{StartMessage}");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public static void ShowSpinner()
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
        DateTime spinner = startTime.AddSeconds(5);
        
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
    public static void ShowCountDonw(int Duration)
    {        
        for (int i = 5; i >0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public static void ShowCountUp()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}