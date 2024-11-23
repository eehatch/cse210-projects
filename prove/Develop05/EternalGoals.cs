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
        return $"{GetGoalName} can be completed multiple times.";
    }
    public override void SetGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());

        SimpleGoals eternal = new SimpleGoals(name, description, points, 0);
        _goals.Add(eternal);
    }

}