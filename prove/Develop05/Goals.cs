using System.Dynamic;

public abstract class Goals
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _totalScore;
    //List<Goals> _goals;

    public Goals(string GoalName, string GoalDesc, int GoalPoints, int TotalScore)
    {
        _goalName = GoalName;
        _goalDescription = GoalDesc;
        _goalPoints = GoalPoints;
        _totalScore = TotalScore;
    }

    public string GetGoal()
    {
        return $"{_goalName} + \n{_goalDescription}";
    }
    public void SetGoal()
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
    public int GetTotalPoints()
    {
        return _totalScore;
    }
    public abstract int SetPointValue();
    public abstract int AddPoints();
    public abstract string CompletedGoals();
    public string EndMessage()
    {
        return $"You have {GetTotalPoints()} points!";
    }
    public string SaveGoal()
    {
        string Goal = $"{_goalName} + \n{_goalDescription}";
        string filename = "myFile.txt";
        Console.Write("What is the name of your file? ");
        filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
        outputFile.WriteLine($"{lines}");
        }
        return Goal;
    }
    public string LoadGoal()
    {
        string filename = "myFile.txt";
        Console.Write("What is the name of your file? ");
        filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        return filename; //CHANGE THIS
    }
    public string DisplayGoal()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string _goalName = parts[0];
            string _goalDescription = parts[1];
        } 
        return _goalName;
    }

}