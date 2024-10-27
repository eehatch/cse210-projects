using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer!!"); 
        Thread.Sleep(1000); //pause 1 second

        // Word myword = new Word("Behold");
        // myword.Display(); 
        // Console.WriteLine();


        Reference r = new Reference("Proverbs", 3, 5, 6);
        Scripture s = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding.\nIn all thy ways acknowledge him, and he shall direct thy paths.", r);
        s.Display(); 
        Console.WriteLine();


        while (!s.AllHidden())
        {   
            // Console.Clear();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit" )
            {
                break;
            }
            s.HideWords();
            s.Display();
        }
    }
}