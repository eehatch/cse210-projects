public class Comment
{
    private string _name;
    private string _text;

    public Comment(string Name, string Text)
    {
        _name = Name;
        _text = Text;
    }

    public void Display()
    {
        Console.WriteLine($"{_name}: {_text}");

    }
}