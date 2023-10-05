using System;
// This is just a structure
public class Resume
{
    // Properties
    public string Name;
    public List<Job> Jobs = new List<Job>(); // this is a 'type' tells us what will be in the list
    
    // Constructor
    public Resume()
    {
    }
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}






// public class Student{
   // public string FirstName { get; set; }   {get set} is the same as FirstName () for right now
   // public string LastName { get; set; }   
//    public string INumber { get; set; }

    //public Resume()

// type in PROP tab, change to string, tab tab, change the name, tab tab enter, repeat!
// this code is a random example, nothing to do with this assignment. should have code in anotehr file.
// **the other page** Student billy = new Student();