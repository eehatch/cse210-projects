public class SimpleGoals : Goals
{
    private bool _isComplete;

    public SimpleGoals(string GoalName, string GoalDesc, int GoalPoints, int TotalScore) : base(GoalName, GoalDesc, GoalPoints, TotalScore)
    {
        GoalPoints = 0;
    }
    public override int SetPointValue()
    {
        return 0;
    }
    public override int AddPoints()
    {
        throw new NotImplementedException(); //incorrect
    }
    public override string CompletedGoals()
    {
        throw new NotImplementedException(); //incorrect
    }
}