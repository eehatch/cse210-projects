using System;
using System.Dynamic;

public class Reference{
    private string _book;
    private string _chapter; 
    private string _verse; 
    private string _lastVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = "";
    }
    
    
    public Reference(string book, string chapter, string verse, string lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = lastVerse;
    }

    public string DisplayReference()
    {
        if (_lastVerse.Length > 0)
        {
            return _book + _chapter + ":" + _verse + "-" + _lastVerse;
        }
        else if (_lastVerse.Length == 0)
        {
            return _book + _chapter + ":" + _verse;
        }
        else
            return "This is not a correct verse";
    }
}