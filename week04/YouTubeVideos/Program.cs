ususing System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video1 and added comments

        Video myVideo1 = new Video("How to enroll at BYU Pathway Online Program?", "Kevin  D. Chacha", 500);
        myVideo1.AddComment(new Comment("Micheal Gborluo", "Great tutorial, very helpful!"));
        myVideo1.AddComment(new Comment("Matthew P. Kollie", "Thanks for sharing."));
        myVideo1.AddComment(new Comment("Precious D. Korvah", "I Will enroll soon. Thanks for sharing."));
        myVideo1.AddComment(new Comment("Yassah Zubah", "Thank you Moses for sharing this interesting lessons."));
        videos.Add(myVideo1);

        // The second video and comments

        Video myVideo2 = new Video("C# Tutorial for Beginners", "Kevin D. Chacha", 600);
        myVideo2.AddComment(new Comment("Marduo Zarwu", "Great tutorial, very helpful!"));
        myVideo2.AddComment(new Comment("Junior Gbor", "Thanks! I finally understand classes in C# programming Language."));
        myVideo2.AddComment(new Comment("Matthew D. Browne", "Thanks for sharing."));
        myVideo2.AddComment(new Comment("Dacious R. Moore", "This is interesting. Thanks for sharing."));
        videos.Add(myVideo2);

        // Creating the third video and adding comments

        Video myVideo3 = new Video("How to use Github technology?", "Prince David", 800);
        myVideo3.AddComment(new Comment("Flourish P. Seah", "Thank you Prince for sharing. This is interesting."));
        myVideo3.AddComment(new Comment("Justine Yakpazuo", "Great tutorial, very helpful!"));
        myVideo3.AddComment(new Comment("Daniel Gban", "Thanks! I have finally understand how to use github."));
        myVideo3.AddComment(new Comment("Erasmus Zorgbah", "Thanks for sharing."));
        videos.Add(myVideo3);

        // Displaying all videos and added comments
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}