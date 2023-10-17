using System.Security.Authentication.ExtendedProtection;

public class Scripture{
    private string _scriptureText;

    public Scripture(string text)
    {
        _scriptureText = text;
    }
    public string GetScripture()
    {
        return _scriptureText;
    }
}