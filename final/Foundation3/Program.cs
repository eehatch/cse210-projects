class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Lecture lecture1 = new Lecture(85, "Karen '404 Chill Not Found' Patel","“Can I Get Uhhhh Mindfulness?”: A Meditation Guide for the Terminally Online", "Too many tabs open in your brain? This workshop will teach you mindfulness techniques to help you unplug—or at least mute the chaos. Free Wi-Fi provided.", "December 20th, 2024", "6:00 am", "1234 way");
        events.Add(lecture1);

        Reception reception1 = new Reception("1234@gmail.com", "A Wedding", "We are excited to unify these two families during this event and lunch.", "January 3rd, 2024", "4:15 pm", "6543 Ave");
        events.Add(reception1);

        OutdoorGathering outdoorGathering1 = new OutdoorGathering("cloudy with some rain", "This is a title!", "Very vague description.", "December 25th, 2023", "6:00 pm", "Address goes here");
        events.Add(outdoorGathering1);

        Console.WriteLine($"{outdoorGathering1.GetStandardDetails()}");
        Console.WriteLine($"{outdoorGathering1.GetShortDescription()}");
        Console.WriteLine($"{outdoorGathering1.GetFullDetails()}\n");
        Console.WriteLine($"{lecture1.GetStandardDetails()}");
        Console.WriteLine($"{lecture1.GetShortDescription()}");
        Console.WriteLine($"{lecture1.GetFullDetails()}\n");
        Console.WriteLine($"{reception1.GetStandardDetails()}");
        Console.WriteLine($"{reception1.GetShortDescription()}");
        Console.WriteLine($"{reception1.GetFullDetails()}\n");

    }
}