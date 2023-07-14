using System;

namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video();
            Video video2 = new Video();
            Video video3 = new Video();
            // adding videos

            video.Time(120);
            video.Title("Trying new taco bell food");
            video.Author("MrMan");
            video.comments.AddComment("JoMama","That Looks disgusting!");
            video.comments.AddComment("MrMan","I will never forget this moment.");
            video.comments.AddComment("MrDank","NGL I'm interested.");
            video.comments.AddComment("MrDank","I tried it, never mind.");

            video2.Time(300);
            video2.Title("Reacting to MrMan's taco bell food!!!");
            video2.Author("MrDank");
            video2.comments.AddComment("MrDank","Loved making this video!");
            video2.comments.AddComment("MrMan","Did you get diarheah too?");
            video2.comments.AddComment("MrDank","YEAH!");

            video3.Time(1120);
            video3.Title("How to Photoshop Memes");
            video3.Author("Knowing Meming");
            video3.comments.AddComment("Jeff","How's this?");
            video3.comments.AddComment("Knowwing Meming","Great!");
            video3.comments.AddComment("Jeff","Thank you");
            video3.comments.AddComment("Knowing Meming","You're welcome!!");
            
            video.ShowVideo();
            video2.ShowVideo();
            video3.ShowVideo();
        }
    }
}