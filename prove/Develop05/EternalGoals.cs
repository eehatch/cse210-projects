public class EternalGoals : Goals
{
    public EternalGoals(string GoalName, string GoalDesc, int GoalPoints, int TotalScore) : base(GoalName, GoalDesc, GoalPoints, TotalScore)
    {

    }
    public override int SetPointValue()
    {
        return 0;
    }
    public override int AddPoints() //incorrect
    {
        throw new NotImplementedException();
    }
    public override string CompletedGoals() //incorrect
    {
        throw new NotImplementedException();
    }
}