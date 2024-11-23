using System.Dynamic;

abstract public class Goals
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected int _totalScore;
    protected List<Goals> _goals;

    public Goals(string GoalName, string GoalDesc, int GoalPoints, int TotalScore)
    {
        _goalName = GoalName;
        _goalDescription = GoalDesc;
        _goalPoints = GoalPoints;
        _totalScore = TotalScore;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDesc()
    {
        return _goalDescription;
    }
    public abstract void SetGoal();
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
    public void SaveGoal()
    {
        // string Goal = $"{_goalName} + \n{_goalDescription}";
        string goalName = "myFile.txt";
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(goalName);
        using (StreamWriter outputFile = new StreamWriter(goalName))
        {
            foreach(Goals goal in _goals)
            {
                Console.WriteLine($"{_goals}");
            }
        }
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