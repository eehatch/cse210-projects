using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        string menu = "";

        // int PointAmount = Goal.CreateGoal();

        while (menu != "6") {
            Console.WriteLine($"You have {GetPointAmount()} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Console.ReadLine();

            if (menu == "1"){
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goals");
                Console.WriteLine("3. Checklist Goals");
                Console.Write("What type of goal would you like to create? ");
                string goaltype = Console.ReadLine();

                if (goaltype == "1"){
                    Console.Write("Enter your simple goal name: ");
                    name = Console.ReadLine();
                    SimpleGoal simpleGoal = new SimpleGoal(name,
                    "",
                    "",
                    "" );
                }
                else if (goaltype == "2"){
                    EternalGoal eternalGoal = new EternalGoal("","",""); 
                }
                else if (goaltype == "3"){
                    ChecklistGoal checklistgoal  = new ChecklistGoal("","","","" ,"" );
                }
                else{
                    Console.WriteLine("Invalid goal type. Please try agian");
                }
            }
        }

    }
}