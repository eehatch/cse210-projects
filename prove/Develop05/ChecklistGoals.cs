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
}