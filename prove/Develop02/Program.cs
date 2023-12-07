using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;
using System.Xml;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // ToDo:
        // Create a Journal object
        // prompt the user with menu
        List<string> prompts = new List<string>{
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was on your mind today?",
            "What miracles did you see today?",
            "Describe your day using a song: ",
            "What did you learn today?"
        };
        // if user picks option to add a new entry
        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Count)];
        // 1: pick a random prompt from list above
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please Select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. quit");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
        // 2. display random prompt
        if (choice == "1")
        {
            Console.WriteLine(randomPrompt);
            Console.Write("> ");
            string response = Console.ReadLine();
            Entry entry = new Entry
            {
                Prompt = randomPrompt,
                Response = response,
                EntryDate = DateTime.Now
            };
        }
        // 3. save entry from user
        else if (choice == "2")
        {
            Console.WriteLine($"{DisplayEntry()}");
        }  
        // 4. create Entry object
           
        // 5. Save Entry object to Journal object
            Console.Write("What is the filename? ");
            string FileName = Console.ReadLine();
        // 5.
        Entry Response = new Entry{
                Prompt = randomPrompt,
                Response = choice,
                EntryDate = DateTime.Now

            };

        // 6. Create a Journal
        Journal journal = new Journal();
        journal.JournalName ="Emily Hatch"; // ask user for their name
        journal.Entries.Add(Response);

        List<string> Entries = new List<string>();
        foreach (Entry entries in Entries)
        {
            entries.DisplayEntry();
        }

        SaveToFile(entry);
        // save journal to file system
    }

    public static void SaveToFile(List<Entry> files)
    {
        Console.WriteLine("Saving to file...");
        
        Console.Write("What would you like to call your Journal? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Journal i in files)
            {
                outputFile.WriteLine(Entries);
            }
        }

    }

}