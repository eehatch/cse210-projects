using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2021;
        // job1.Display();

        Job job2 = new();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2021;
        job2._endYear = 2024;
        // job2.Display();

        Resume myResume = new();
        myResume.name = "Emily Hatch";

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.Display();
    }
}