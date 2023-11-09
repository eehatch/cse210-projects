using System.ComponentModel.DataAnnotations;

public class Breathing : Activity
{

    public Breathing(string StartMessage, int Duration): base(StartMessage, Duration)
    {
    }

    public override void StartMessage()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

    }
    public static int GetDisplay()
    {
        
    }
}