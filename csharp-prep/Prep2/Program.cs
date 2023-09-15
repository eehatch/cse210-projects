using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int x = int.Parse(grade);

        string letter = "";

        if (x >= 93)
        {    
            letter = "A";
        }
        else if (x >= 90)
        {
            letter = "A-";
        }
        else if (x >= 87)
        {
            letter = "B+";
        }
        else if (x >= 83)
        {
            letter ="B";
        }
        else if (x >= 80)
        {
            letter = "B-";
        }
        else if (x >= 77)
        {
            letter = "C+";
        }
        else if (x >= 73)
        {
            letter = "C";
        }
        else if (x >= 70)
        {
            letter = "C-";
        }
        else if (x >= 67)
        {
            letter = "D+";
        }
        else if (x >= 63)
        {
            letter = "D";
        }
        else if (x >= 60)
        {
            letter = "D-";
        }
        else if (x < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");
        
        if (x >= 70)
        {
            Console.WriteLine("Congradulations, you have passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
        
    }
}