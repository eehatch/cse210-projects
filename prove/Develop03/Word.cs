using System;
using System.Collections.Concurrent;

public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string Text)
    {
        _text = Text;
    }
    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }
    public string Display()
    {
        return _hidden ? new string('_', _text.Length) : _text;
        
    }
    public bool IsHidden()
    {
        return _hidden;
    }
}