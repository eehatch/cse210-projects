public class Math : Assignment
{
    private string _textbookSelection;
    private string _problems;

    public Math(string Textbook, string Problems, string StudentName, string Topic) : base(StudentName, Topic)
    {
        _textbookSelection = Textbook;
        _problems = Problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSelection} Problems: {_problems}";
    }
}