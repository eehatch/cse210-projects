using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running(3.0, "03 Nov 2022", 30);
        activities.Add(running1);

        Cycling cycling1 = new Cycling(18, "07 Dec 2022", 95);
        activities.Add(cycling1);

        Swimming swimming1 = new Swimming(30, "17 Jan 2023", 50);
        activities.Add(swimming1);

        Console.WriteLine($"\n{running1.GetSummary()}");
        Console.WriteLine($"{cycling1.GetSummary()}");
        Console.WriteLine($"{swimming1.GetSummary()}\n");
    }
}    