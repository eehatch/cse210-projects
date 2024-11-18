using System.Dynamic;

public abstract class Goals
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _totalScore;
    List<Goals> _goals;

    public Goals(string GoalName, string GoalDesc, int GoalPoints, int TotalScore)
    {
        _goalName = GoalName;
        _goalDescription = GoalDesc;
        _goalPoints = GoalPoints;
        _totalScore = TotalScore;
    }

    public string GetGoal()
    {
        string Goal = $"{_goalName} + \n{_goalDescription}";
        return Goal;
    }
    public void SetGoal(string GoalName, string GoalDesc)
    {
        _goalName = GoalName;
        _goalDescription = GoalDesc;
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
        return $"You have completed all your goals and earned {GetTotalPoints()} points!";
    }
    public string SaveGoal()
    {
        string Goal = $"{_goalName} + \n{_goalDescription}";
        _goals.Add(Goal);
        return Goal; //CHANGE THIS
    }
    public string LoadGoal()
    {
        return _goalDescription; //CHANGE THIS
    }
    public string DisplayGoal()
    {
        return _goalName; //CHANGE THIS
    }

}