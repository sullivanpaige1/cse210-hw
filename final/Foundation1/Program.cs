using System;

namespace YouTubeVideos
{
    class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }

    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; } // seconds
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return Comments.Count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {Length} seconds");
            Console.WriteLine($"Number of comments: {GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("Python Tutorial", "Alice", 600);
            video1.AddComment(new Comment("Bob", "Great tutorial!"));
            video1.AddComment(new Comment("Carol", "Very helpful."));
            video1.AddComment(new Comment("Dave", "Thanks for sharing."));

            Video video2 = new Video("Learn Java", "Eve", 900);
            video2.AddComment(new Comment("Frank", "Awesome!"));
            video2.AddComment(new Comment("Grace", "Clear explanations."));
            video2.AddComment(new Comment("Heidi", "Loved it!"));

            Video video3 = new Video("C++ Basics", "Ivan", 750);
            video3.AddComment(new Comment("Judy", "Good intro."));
            video3.AddComment(new Comment("Karl", "Helpful examples."));
            video3.AddComment(new Comment("Leo", "Nice video."));

            List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (var v in videos)
            {
                v.DisplayInfo();
            }
        }
    }
}

