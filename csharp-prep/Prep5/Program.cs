using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = GetUserName();
        int userNumber = AddNumbers();

        int squareNumber = SquareNumber(userNumber);

        DisplayPersonalMessage(userName, squareNumber);
    }
    
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int AddNumbers()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayPersonalMessage(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
      
}