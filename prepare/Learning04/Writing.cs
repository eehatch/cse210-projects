public class Writing : Assignment
{
    private string _title;

    public Writing(string Title, string StudentName, string Topic) : base(StudentName, Topic)
    {
        _title = Title;
    }
    public string GetWritingInformation()
    {
        string StudentName = GetStudentName();
        return $"{_title} by {StudentName}";
    }
}