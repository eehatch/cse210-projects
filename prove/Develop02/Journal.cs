using System;

public class Journal
{
    public List<Entry> entries = new();

    public void Save()
    {
        Console.WriteLine("What would you like to name your file? ");
    }
    public void Load()
    {
        Console.WriteLine("What file would you like to load? ");
    }
    public void Display()
    {

    }
}