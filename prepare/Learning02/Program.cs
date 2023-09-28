using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); /// this is creating a new instance
        job1.JobTitle = "Software Engineer"; /// new variable!
        job1.Company = "Microsoft";
        job1.StartYear = 2019;
        job1.EndYear = 2022;


// either one of the methods work. () or {}
        Job job2 = new Job
        {
        JobTitle = "Manager",
        Company = "Apple",
        StartYear = 2022,
        EndYear = 2023
        };

        Resume myResume = new Resume();
        myResume.Name = "Allison Rose";

        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.DisplayResume();
    }
}