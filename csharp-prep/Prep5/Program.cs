using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello world!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userNum = int.Parse(Console.ReadLine());
        return userNum;
    }

    static int SquareNumber()
    {
        Console.Write("Enter a Number: ");
        int num = int.Parse(Console.ReadLine());
        int square = num * num;
        return square;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square root of your number is {square}");

    }
}