using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer!!"); 
        Thread.Sleep(1000); //pause 1 second

        Reference r2 = new Reference("1 Nephi", 2, 25);
        Scripture s2 = new Scripture("Adam fell that men might be; and men are, that they might have joy.", "1 Nephi 2:25" );
        s2.Display(); 
        Console.WriteLine();

        //Console.Read();
        // Console.Clear();
        while (true)
        {   
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit" )
            {
                break;
            }
            s2.Display();
            break;
        }
    }
}