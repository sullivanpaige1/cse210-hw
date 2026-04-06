using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Video 1", "sillystring_89", 300);
        v1.AddComment(new Comment("Bob", "Nice Job!"));
        v1.AddComment(new Comment("Sue", "Cool!"));

        Video v2 = new Video("Video 2", "Papasullii", 400);
        v2.AddComment(new Comment("Tom", "This is an interesting video!"));
        v2.AddComment(new Comment("Ana", "Great video haha!"));

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}

