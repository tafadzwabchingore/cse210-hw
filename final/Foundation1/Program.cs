using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "C# Tutorial for Beginners",
            Author = "Programming with Mosh",
            Length = 3600,
            Comments = new List<Comment>
            {
                new Comment { Name = "John", Text = "Great tutorial!" },
                new Comment { Name = "Jane", Text = "Thanks for sharing!" },
                new Comment { Name = "Bob", Text = "Very helpful, thanks!" }
            }
        };

        Video video2 = new Video
        {
            Title = "ASP.NET Core Tutorial",
            Author = "FreeCodeCamp",
            Length = 5400,
            Comments = new List<Comment>
            {
                new Comment { Name = "Alice", Text = "Awesome tutorial!" },
                new Comment { Name = "Dave", Text = "Thanks for the help!" },
                new Comment { Name = "Sarah", Text = "Very informative, thanks!" }
            }
        };

        Video video3 = new Video
        {
            Title = "Unity Game Development Tutorial",
            Author = "Brackeys",
            Length = 7200,
            Comments = new List<Comment>
            {
                new Comment { Name = "Mike", Text = "This is amazing!" },
                new Comment { Name = "Emily", Text = "Thanks for the tutorial!" },
                new Comment { Name = "Tom", Text = "Very helpful, thanks!" }
            }
        };

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine(comment.Name + ": " + comment.Text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
