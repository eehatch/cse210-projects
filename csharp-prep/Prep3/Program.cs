using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 40);

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

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