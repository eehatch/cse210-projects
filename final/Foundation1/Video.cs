public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> comments = new List<Comment>();

    public Video(string Title, string Author, int Length)
    {
        _title = Title;
        _author = Author;
        _length = Length;
    }
    public int GetCommentCount()
    {
        int count = 0;
        count = comments.Count;
        Console.WriteLine($"comments: {count}");
        return count;
    }
    public void ListComment()
    {
        foreach (Comment comment in comments)
        {
            comment.Display();
        }
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"\n{_title} by: {_author}, {_length} minutes\n");

        
    }
}