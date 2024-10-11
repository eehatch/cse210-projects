using System;

public class Entry 
{
    public string _note;
    public string _date;
    public string _prompt;
    public void Write()
    {
        Console.WriteLine($"{_date}\n{_prompt}\n{_note}\n");
    }
}