public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private int CountComments()
    {
        return _comments.Count();
    }

    public void Display()
    {
        Console.WriteLine($"{_title} - {_author}");
        Console.WriteLine($"Number of Comments: {CountComments()}");
        
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }




}