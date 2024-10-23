using System;
using System.Collections.Concurrent;

public class Word
{
    private string _text;
    private bool _hidden;

    public void SetWord(string Text)
    {
        _text = Text;
        _hidden = false;
    }
    public string GetWord()
    {
        return _text;
    }
    public void Hide()
    {
        _text = "__";
    }
    public bool IsHidden()
    {
        _hidden = true;
        return _hidden;
    }
    // public void Show()
    // {

    // }
    // public void Display()
    // {
        
    // }
}