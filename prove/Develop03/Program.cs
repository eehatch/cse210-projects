using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference();
        Console.WriteLine(r1.GetReference());
        Console.WriteLine(r1.GetVerseText());
        
        Reference r2 = new Reference();
        Console.WriteLine(r2.GetReference());
        Console.WriteLine(r2.GetVerseText());
        
        Reference r3 = new Reference();
        Console.WriteLine(r3.GetReference());
        Console.WriteLine(r3.GetVerseText());


    }
}