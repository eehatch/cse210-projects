using System;

public class Resume
{
    public string Name;

    public List<Job> Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}






// public class Student{
   // public string FirstName { get; set; }   
   // public string LastName { get; set; }   
//    public string INumber { get; set; }

    //public Resume()

// type in PROP tab, change to string, tab tab, change the name, tab tab enter, repeat!
// this code is a random example, nothing to do with this assignment. should have code in anotehr file.
// **the other page** Student billy = new Student();