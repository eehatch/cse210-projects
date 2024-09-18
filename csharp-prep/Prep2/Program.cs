using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);


        if (grade >= 90)
        {
            Console.WriteLine("greater than y");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("greater than z");
        }
        else
        {
            Console.WriteLine("less than both");
        }
    }
}