using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Magic Number? ");
        string input =  Console.ReadLine();
        int magicNum = int.Parse(input);

        Console.Write("What is your guess? ");
        string student = Console.ReadLine();
        int guess = int.Parse(student);

        if (guess == magicNum)
        {
            Console.WriteLine("You Guessed it!");
        }
        else if (guess > magicNum)
        {
            Console.WriteLine("Lower!");
        }
        else if (guess < magicNum)
        {
            Console.WriteLine("Higher!");
        }
     
    }
}