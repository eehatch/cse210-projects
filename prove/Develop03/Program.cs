using System;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");


        Reference r1 = new Reference("Alma", "7", "11", "12", "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.");
        Console.WriteLine(r1.GetReference());
        Console.WriteLine(r1.GetVerseText());
        
        Reference r2 = new Reference("2 Nephi", "2", "25","", "Adam fell that men might be; and men are, that they might have joy.");
        Console.WriteLine(r2.GetReference());
        Console.WriteLine(r2.GetVerseText());

        // Scripture s1 = new Scripture("And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.");
        // Console.WriteLine(r1.GetReference(), s1.GetScripture());
        // Console.ReadLine();
        // Console.Clear();

        // Scripture s2 = new Scripture("Adam fell that men might be; and men are, that they might have joy.");
        // Console.WriteLine(s2.GetScripture(), r2.GetReference());
        // Console.ReadLine();
        // Console.Clear();

    }
}