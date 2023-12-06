using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running(150, "Sept. 15, 2023", 150);
        activities.Add(running1);

        Console.WriteLine($"{running1.GetSummary()}");
    }
}