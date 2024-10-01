using System;
public class Resume
{
    public string name;
    public List<Job> jobs = new();

    public void Display()
    {
        Console.WriteLine($"{name}\nJobs:");

        foreach (Job job in jobs)
        {
            job.Display();
        }
    }

}