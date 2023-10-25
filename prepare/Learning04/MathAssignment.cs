public class MathAssignment : Assignment
{
    private string _textbookSelection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string TextbookSelection, string Problems): base(studentName, topic)
    {
        _textbookSelection = TextbookSelection;
        _problems = Problems;
    }

    public string GetTextbookSelection()
    {
        return _textbookSelection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSelection} Problems {_problems}";
    }
}