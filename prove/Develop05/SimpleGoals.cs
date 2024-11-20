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
}