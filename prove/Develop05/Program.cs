using System;
class Program
{
    static void Main(string[] args)
    {
        string choice = " ";
        List<Goals> goals = new();
        
        // Goals newGoal = new();

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
                    SimpleGoals simple = new("", "", 0, 0);
                    simple.SetGoal();
                    goals.Add(simple);
                }
                else if (choice2 == "2")
                {
                    EternalGoals eternal = new("", "", 0, 0);
                    eternal.SetGoal();
                    goals.Add(eternal);
                }
                else if (choice2 == "3")
                {
                    ChecklistGoals checklist = new("", "", 0, 0, 0);
                    checklist.SetGoal();
                    goals.Add(checklist);
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
                    Console.WriteLine(goal.GetGoalName());
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