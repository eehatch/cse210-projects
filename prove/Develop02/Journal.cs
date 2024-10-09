using System;

public class Journal
{
    public List<Entry> entries = new();

    public void Save()
    {
        Console.WriteLine("What would you like to name your file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(entries);
            
        }
    }
    public void Load()
    {
        Console.Write("What is the filename? ");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                // the name of the different files?
            }
    }
    public void Display() //done!!
    {
        foreach (Entry entry in entries)
        {
            entry.Write();
        }

    }
}