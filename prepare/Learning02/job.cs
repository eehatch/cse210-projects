using System;
public class Job
{
    public string JobTitle;
    public string Company;
    public int StartYear;
    public int EndYear;

    public void Display() /// this is the 1 method we needed for this project
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}