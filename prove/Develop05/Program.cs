using System;
class Program
{
    static void Main(string[] args)
    {
        string choice = " ";
        List<Goals> goals = new();
        Goals newgoal = new();

        do
        {
            Console.WriteLine($"\nYou have {0} points.");
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
                string choice2 = " ";
                Console.WriteLine("1. Simple Goal ");
                Console.WriteLine("2. Eternal Goal ");
                Console.WriteLine("3. Checklist Goal ");
                Console.WriteLine("What kind of Goal would you like to create? ");
                choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    // How to incorporate inheritance
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = Convert.ToInt32(Console.ReadLine());

                    SimpleGoals simple = new SimpleGoals(name, description, points, 0);
                    goals.Add(simple);
                }
                else if (choice2 == "2")
                {
                    newgoal.SetGoal();
                }
                else if (choice2 == "3")
                {
                    Console.Write("What is the name of your goal? ");
                    Console.Write("What is a short description of it? ");
                    Console.Write("What is the amount of points associated with this goal? ");

                    //look at above, USE INHERITANCE

                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }     
            }
            else if (choice == "2") //list goal
            {
                foreach (Goals goal in goals)
                {
                    Console.WriteLine(goal.GetGoal());
                }
                
            }
            else if (choice == "3") //Save goal
            {
                 //console.ReadLine possibly??
                
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