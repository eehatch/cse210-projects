using System;

public class Journal
{
    public List<Entry> entries = new();

    public void Save() //Done i think!
    {
        Console.WriteLine("What would you like to name your file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._note}");
            }
        }
    }
    public void Load()
    {
        Console.Write("What is the filename? ");
        string filenames = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filenames);
        // entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            // the name of the different files?
            Entry entry = new Entry
            {
                _date = parts[0],
                _prompt = parts[1],
                _note = parts[2]
            };
            entries.Add(entry);
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