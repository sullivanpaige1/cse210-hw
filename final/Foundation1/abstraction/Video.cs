using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine(_title + " by " + _author);
        Console.WriteLine("Length: " + _length);
        Console.WriteLine("Comments: " + GetCommentCount());

        foreach (Comment c in _comments)
        {
            Console.WriteLine(c.GetName() + ": " + c.GetText());
        }

        Console.WriteLine("----------------");
    }
}