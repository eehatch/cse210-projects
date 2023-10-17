using System.Dynamic;

public class Reference{
    private string _book;
    private string _chapter; 
    private string _verse; 
    private string _lastVerse;
    private string _verseText;

    public Reference(string book, string chapter, string verse, string lastVerse, string verseText)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = lastVerse;
        _verseText = verseText;
    }
    public string GetReference()
    {
        string reference = $"{_book} {_chapter}:{_verse}-{_lastVerse}";
        return reference;
    }
    public string GetVerseText()
    {
        return _verseText;
    }
}