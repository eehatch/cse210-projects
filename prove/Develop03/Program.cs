using System;
using System.ComponentModel;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();
        // if (input.Length == 0)
        // {

        // }
        // else if (input.ToLower() == "quit")
        // {
        //     return;
        // }
        // Console.ReadKey();

        Reference r1 = new Reference("Alma ", "7", "11", "12");
        Console.ReadLine();

        Reference r2 = new Reference("2 Nephi ", "2", "25");
        Console.ReadLine();

        Scripture s1 = new Scripture("And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.");
        Console.ReadLine();
        Console.WriteLine($"{r2.DisplayReference()} \n {s1.GetScripture()}");

        


        // Scripture s2 = new Scripture("Adam fell that men might be; and men are, that they might have joy.");
        // Console.ReadLine();
        // Console.WriteLine($"{r2.DisplayReference} \n {s2.GetScripture}");
    }
}