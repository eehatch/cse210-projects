using System.Diagnostics.Contracts;

public class Entry {
    public DateTime EntryDate;
    public string Prompt;
    public string Response;

    public void DisplayEntry()
    {
        Console.WriteLine($"{EntryDate}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"{Response}");
    }


}