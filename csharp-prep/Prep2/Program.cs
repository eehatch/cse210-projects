using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";

        if (grade >= 93)
        {    
            letter = "A";
        }
        else if (grade >= 90)
        {
            letter = "A-";
        }
        else if (grade >= 87)
        {
            letter = "B+";
        }
        else if (grade >= 83)
        {
            letter ="B";
        }
        else if (grade >= 80)
        {
            letter = "B-";
        }
        else if (grade >= 77)
        {
            letter = "C+";
        }
        else if (grade >= 73)
        {
            letter = "C";
        }
        else if (grade >= 70)
        {
            letter = "C-";
        }
        else if (grade >= 67)
        {
            letter = "D+";
        }
        else if (grade >= 63)
        {
            letter = "D";
        }
        else if (grade >= 60)
        {
            letter = "D-";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Try again, you can do it!");    
        }
    }
}