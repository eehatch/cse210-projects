using System;
using System.Reflection.Emit;

public class Reference
{
    public string _book;
    public int _chapter;
    public int _firstVerse;
    public int _lastVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = verse;
        // return $"{_book} {_chapter}: {_firstVerse} - {_lastVerse}";

    } 
    
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
        // return $"{_book} {_chapter}: {_firstVerse} - {_lastVerse}";

    }   
    public void Display()
    {
        if (_firstVerse == _lastVerse) 
        {
            Console.WriteLine($"{_book} {_chapter}: {_firstVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_firstVerse} - {_lastVerse}");
        }
    }
}