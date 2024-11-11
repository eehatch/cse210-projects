using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        
        Reflection reflection = new("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Breathing breathing = new("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Listing listing = new("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        do
        {
            Console.WriteLine("\nWelcome to the Mindfulness Program!");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1") //breathe
            {
                breathing.Breathe();
            }
            else if (choice == "2") //reflect
            {
                reflection.Reflect();
            }
            else if (choice == "3") //list
            {
                listing.List();
            }
            else if (choice == "4") //quit
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
        while (choice != "4");
    }
}