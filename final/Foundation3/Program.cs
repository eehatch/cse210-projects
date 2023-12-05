using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Lecture lecture1 = new Lecture(85, "Emily Hatch","Emojis as the New Universal Language", "Join us for an engaging lecture that explores the fascinating world of 'Emojis as the New Universal Language.' In this thought-provoking session, we will delve into the evolution of emojis and their profound impact on communication in the digital age. From their humble beginnings as simple smiley faces to becoming a rich and dynamic visual language, emojis have transcended cultural and linguistic barriers, offering a universal means of expression", "December 5th, 2024", "6:00 am", "1234 way");
        events.Add(lecture1);

        Reception reception1 = new Reception("1234@gmail.com", "A Wedding", "We are excited to unify these two families during this event and lunchin.", "January 3rd, 2024", "4:15 pm", "6543 Ave");
        events.Add(reception1);

        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Cloudy with some rain", "TITLE GOES HERE", "VERY VAGUE DESCRIPTION", "December 25th, 2023", "6:00 pm", "Address goes here");
        // fix date here pls
        events.Add(outdoorGathering1);



    }
}