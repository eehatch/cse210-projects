using System.Diagnostics.Contracts;

public class Entry {
    public string EntryDate {get; set;}
    public string Prompt {get; set;}
    public string Response {get; set;}


    public void DisplayEntry()
    {
        Console.WriteLine($"{EntryDate}");
        Console.WriteLine($"{Prompt}");
        Console.WriteLine($"{Response}");

        

    }


}