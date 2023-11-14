public class ChecklistGoal : Goal
{
    private int _repetitions;
    private int _completedRepetitions;

    public ChecklistGoal(string Name, string Description, int PointAmount, int Repetitions): base(Name, Description, PointAmount, true)
    {
        
    }
}