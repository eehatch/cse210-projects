public class ChecklistGoals : Goals
{
    private int _isComplete;
    private int _totalCompleted;
    private int _extraPoints;

    public ChecklistGoals(string GoalName, string GoalDesc, int GoalPoints, int TotalScore, int ExtraPoints) : base(GoalName, GoalDesc, GoalPoints, TotalScore)
    {
        _extraPoints = ExtraPoints;
    }
    public override int SetPointValue() //incorrect
    {
        return 0;
    }
    public override int AddPoints() //incorrect
    {
        return _extraPoints;
    }
    public override string CompletedGoals() //incorrect
    {
        return "";
    }
        public override void SetGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());

        SimpleGoals checklist = new SimpleGoals(name, description, points, 0);
        _goals.Add(checklist);
        
    }
}