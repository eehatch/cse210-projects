using System;

public class Scripture
{
    private string _text;
    // private string _reference;
    private Reference _reference;
    private List<Word> _words = new();
    private Random _rand = new();

    public Scripture(string Text, Reference reference)
    {
        _text = Text;
        _reference = reference;
        _words = SplitScripture(Text);
    }
    public List<Word> SplitScripture(string Text)
    {
        _text = Text;
        string[] splitWords = Text.Split(' ');
        
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));

        }
        return _words;
    }
    public void HideWords()
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        int wordsHide = Math.Min(2, visibleWords.Count);

        for (int i = 0; i < wordsHide; i++)
        {
            int index = _rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public bool AllHidden()
    {
        return _words.All(w => w.IsHidden());
    }
    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{_reference.GetReference()}\n" + string.Join(" ", _words.Select(w => w.Display())));
    }
}