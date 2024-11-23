public class SimpleGoals : Goals
{
    private bool _isComplete;

    public SimpleGoals(string GoalName, string GoalDesc, int GoalPoints, int TotalScore) : base(GoalName, GoalDesc, GoalPoints, TotalScore)
    {
        _isComplete = false;
    }
    public override int SetPointValue()
    {
        return 0;
    }
    public override int AddPoints()
    {
        return GetTotalPoints(); //incorrect
    }
    public override string CompletedGoals()
    {
        _isComplete = false;
        return ""; //incorrect
    }
        public override void SetGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = Convert.ToInt32(Console.ReadLine());

        
    }
}