using System;

class Program
{
    static void Main(string[] args)
    {
        //ToDo:
        // Create a Journal object
        // prompt the user with menu
    

        List<string> prompts = new List<string>();

        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was on your mind today?");
        prompts.Add("What miracles did you see today?");
        prompts.Add("Describe your day using a song:");
        prompts.Add("?");

        // if user picks option to add a new entry
        // step 1: pick a random prompt from list above
        // 2. display random prompt

        // 3. save entry from user

        // 4. create Entry object
           
        // 5. Save Entry object to Journal object

        // 5.
        Entry entry = new Entry();
        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = ""; // from prompt above;
        entry.Response = ""; // pull from user's response

        // 6. Create a Journal
        Journal journal = new Journal();
        journal.JournalName = ""; // ask user for their name
        journal.Entries.Add(entry);

        // save journal to file system
    }
}