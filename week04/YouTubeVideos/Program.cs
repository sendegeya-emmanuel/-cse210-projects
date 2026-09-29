using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C# in 10 Minutes", "Tech Academy", 600);
        video1._comments.Add(new Comment("Alice", "Great tutorial, very clear!"));
        video1._comments.Add(new Comment("Bob", "Thanks, this helped me a lot."));
        video1._comments.Add(new Comment("Claude", "Is there a part 2 coming?"));
        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("How to Build a Web App", "Code Craftsman", 1200);
        video2._comments.Add(new Comment("David", "Loved the layout and design."));
        video2._comments.Add(new Comment("Emma", "Awesome video, coding along now."));
        video2._comments.Add(new Comment("Frank", "What framework did you use here?"));
        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Object-Oriented Programming Basics", "Professor Bytes", 900);
        video3._comments.Add(new Comment("Grace", "Abstraction makes sense now."));
        video3._comments.Add(new Comment("Henry", "Perfect explanation of classes."));
        video3._comments.Add(new Comment("Ian", "Best programming video on YouTube!"));
        videosList.Add(video3);

        // Iterate through the list and display video details and comments
        foreach (Video video in videosList)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._lengthInSeconds + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine("- " + comment._commenterName + ": " + comment._text);
            }
            
            Console.WriteLine("-------------------------------------------------");
        }
    }
}