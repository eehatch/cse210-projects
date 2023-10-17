
public class Words{
    private string _words;
    public Words (string words)
    {
        _words = words;
    }
    public string GetWords()
    {
        return _words;
    }
    public string HideWords {get; set;}
    public string ShowWords {get; set;}
    public string IsHidden {get; set;}
    public string GetRenderedText {get; set;}
}