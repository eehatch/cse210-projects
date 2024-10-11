using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        List<string> prompts = new();
        prompts.Add("What are three things you're grateful for today, and why?");
        prompts.Add("What could you do to improve your self-care routine?");
        prompts.Add("What do you value most in life?");
        prompts.Add("What’s a fear you’d like to overcome?");
        prompts.Add("What’s your favorite memory from childhood?");
        prompts.Add("Describe your ideal day.");
        prompts.Add("What’s a hobby you enjoy, and why?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        Random random = new Random();
        
        Journal journal = new Journal();
        Entry entry = new();
        entry._date = dateText;
        string choice = "0";
        
        do {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            string randomPrompt = prompts[random.Next(prompts.Count)];

            entry._prompt = randomPrompt;

        
            if (choice == "1") //write
            {
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                entry._note = response; 
            }
            else if (choice == "2") //display
            {
                //journal.Display();
                entry.Write();
            }
            else if (choice == "3") //load
            {
                journal.Load();
            }
            else if (choice == "4") //save
            {
                journal.Save();
            }
            else if (choice == "5") //save
            {
                Console.WriteLine("See you tomorrow!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please choose a valid option.\nJ");
            }
        }
        while (choice != "5");
    }
}