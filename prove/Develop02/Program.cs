using System;
using System.Security.Cryptography.X509Certificates;

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
        prompts.Add("ow did I see the hand of the Lord in my life today?");

        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Count)];


        Entry entry1 = new();
        entry1._date = dateText;
        entry1._prompt = randomPrompt;
        entry1._note = "";

        entry1.Write();
    }
}