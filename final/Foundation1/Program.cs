using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("How To", "HowToGuy", 400);
        video1.AddComment(new Comment("Alice", "Great tips!"));
        video1.AddComment(new Comment("Bob", "I want to try this now."));
        video1.AddComment(new Comment("Charlie", "Very detailed, thanks!"));
        _videos.Add(video1);

        Video video2 = new Video("Comparison", "ThisOrThat", 600);
        video2.AddComment(new Comment("Dave", "This helped a lot."));
        video2.AddComment(new Comment("John", "Can you compare shoes next time?"));
        video2.AddComment(new Comment("Katie", "Nice editing!"));
        _videos.Add(video2);

        Video video3 = new Video("Top 5 Coding Languages", "Top5Girl", 360);
        video3.AddComment(new Comment("Grace", "C# made the list!"));
        video3.AddComment(new Comment("Tom", "Good picks."));
        video3.AddComment(new Comment("Jacob", "Loved the presentation."));
        _videos.Add(video3);


        foreach (Video video in _videos)
            {
                Console.WriteLine($"Title: {video._title}");
                Console.WriteLine($"Author: {video._author}");
                Console.WriteLine($"Length: {video._length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($" - {comment._commenterName}: {comment._text}");
                }

                Console.WriteLine();
            }
        }
}