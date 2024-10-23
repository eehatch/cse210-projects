using System;

public class Scripture
{
    private string _text;
    private string _reference;
    private List<Word> _words = new();


    public Scripture(string Text, string Reference)
    {
        _text = Text;
        _reference = Reference;
    }

    public void SplitScripture(string Text)
    {
        _text = Text;
        Text = "Adam fell that men might be; and men are, that they might have joy.";
        string[] splitWords = Text.Split(' ');
        
        foreach (string word in splitWords)
        {
            
        }

    }
    public void HideWords()
    {

    }
    public void AllHidden()
    {
        // if _text == IsHidden(){}
        Console.Clear();
    }
    public void Display()
    {

    }
}