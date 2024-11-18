using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = " ";
        List<Goals> goals = new();

        do
        {
            Console.WriteLine($"\nYou have {Goals.TotalScore} points.");
            Console.Write("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice From the Menu: ");
            choice = Console.ReadLine();

            if (choice == "1") //new goal
            {
                
            }
            else if (choice == "2") //list goal
            {
                
            }
            else if (choice == "3") //Save goal
            {
                goals.Add(); //console.ReadLine possibly??
                
            }
            else if (choice == "4") //Load goal
            {
                
            }
            else if (choice == "5") //Record Event
            {
                
            }
            else if (choice == "6") //quit
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
        while (choice != "6");

    }
}