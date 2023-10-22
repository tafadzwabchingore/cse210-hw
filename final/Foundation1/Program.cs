using System;
using System.Collections.Generic;
 
namespace YouTubeTracker
{

    // Represents a YouTube video with information such as title, author, length, and comments.
    // </summary>
    public class Video
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int LengthInSeconds { get; private set; }
        public List<Comment> Comments { get; private set; }
 
        // <summary>
        // Constructs a new Video object with the provided title, author, and length.
        //
        // Parameters:
        // - title: The title of the video.
        // - author: The author of the video.
        // - lengthInSeconds: The length of the video in seconds.
        // </summary>
        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            Comments = new List<Comment>();
        }
 
        // <summary>
        // Adds a comment to the video's list of comments.
        //
        // Parameters:
        // - comment: The comment to be added.
        // </summary>
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
 
        // <summary>
        // Returns the number of comments on the video.
        //
        // Returns:
        // - An integer representing the number of comments on the video.
        // </summary>
        public int GetNumberOfComments()
        {
            return Comments.Count;
        }
    }
 
    // <summary>
    // Represents a comment left on a YouTube video.
    // </summary>
    public class Comment
    {
        public string Text { get; private set; }
        public string Author { get; private set; }
 
        // <summary>
        // Constructs a new Comment object with the provided text and author.
        //
        // Parameters:
        // - text: The text of the comment.
        // - author: The author of the comment.
        // </summary>
        public Comment(string text, string author)
        {
            Text = text;
            Author = author;
        }
    }
 
    // Example program for Video and Comment classes.
 
    public class Program
    {
        public static void Main()
        {
            // Create a new video.
            var video = new Video("Introduction to C#", "John Doe", 600);
 
            // Add comments to the video.
            video.AddComment(new Comment("Great video!", "User1"));
            video.AddComment(new Comment("Very informative.", "User2"));
            video.AddComment(new Comment("I learned a lot.", "User3"));
 
            // Get the number of comments on the video.
            int numberOfComments = video.GetNumberOfComments();
            Console.WriteLine($"Number of comments: {numberOfComments}");
        }
    }
}
