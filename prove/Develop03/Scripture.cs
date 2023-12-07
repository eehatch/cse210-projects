using System.Security.Authentication.ExtendedProtection;

public class Scripture{
    private Reference _reference;
    private List<string> _words;
    private string _text;

    public Scripture(string Text, Reference reference)
    {
        _text = Text;
        _words = new List<string>();
        _reference = reference;

        
    }
    public void GetWords()
    {
        
    }
    public void GetScripture()
    {
        string scriptureText1 = "Adam fell that men might be; and men are, that they might have joy.";
        string[] splitwords = scriptureText1.Split(' ');
        
        foreach (string word in splitwords)
        {
            _words.Add(new string(word));
        }
    }

    public void HideWord()
    {
        
    }

}