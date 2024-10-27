using System;
using System.Reflection.Emit;

public class Reference  //DONE
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

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
    public string GetReference()
    {
        if (_firstVerse == _lastVerse) 
        {
            return $"{_book} {_chapter}: {_firstVerse}-{_lastVerse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_firstVerse}-{_lastVerse}";
        }
    }
}