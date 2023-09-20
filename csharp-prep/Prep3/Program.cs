using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magic = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

    if (guess > magic)
    {
        Console.WriteLine("Lower");
    }
    else if (guess < magic)
    {
        Console.WriteLine("Higher");
    }
    else
    {
        Console.WriteLine("You guessed it!");
    }
    }
}