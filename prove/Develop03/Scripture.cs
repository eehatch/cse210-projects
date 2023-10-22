using System.Security.Authentication.ExtendedProtection;

public class Scripture{
    private Reference _reference;
    private List<string> _words;

    public Scripture()
    {
        _words = new List<string>();

        string scriptureText1 = "Adam fell that men might be; and men are, that they might have joy.";
        string[] splitwords = scriptureText1.Split(' ');
        
        foreach (string word in splitwords)
        {
            _words.Add(new string(word));
        }
    }
    public void GetWords()
    {
        
    }
    public void GetScripture()
    {
    }

    public void HideWord()
    {
        
    }

}