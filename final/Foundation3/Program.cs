using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Lecture lecture1 = new Lecture(85, "Emily Hatch","Emojis as the New Universal Language", "Join us for an engaging lecture that explores the fascinating world of 'Emojis as the New Universal Language.' In this thought-provoking session, we will delve into the evolution of emojis and their profound impact on communication in the digital age.", "December 5th, 2024", "6:00 am", "1234 way");
        events.Add(lecture1);

        Reception reception1 = new Reception("1234@gmail.com", "A Wedding", "We are excited to unify these two families during this event and lunch.", "January 3rd, 2024", "4:15 pm", "6543 Ave");
        events.Add(reception1);

        OutdoorGathering outdoorGathering1 = new OutdoorGathering("cloudy with some rain", "This is a title!", "Very vague descriptiom", "December 25th, 2023", "6:00 pm", "Address goes here");
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