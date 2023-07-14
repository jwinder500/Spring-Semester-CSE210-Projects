using System;

namespace Foundation1
{
    public class Video
    {
        public Comments comments = new Comments();
        private int Length;
        private string title;
        private string channel;
        public void Time(int time)
        {
            Length = time;
        }
        public void Title(string name)
        {
            title = name;
        }
        public void Author(string author)
        {
            channel = author;
        }
        public void ShowVideo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {channel}");
            Console.WriteLine($"Time: {Length}");
            Console.WriteLine();
            Console.WriteLine("Comments:");
            Console.WriteLine();
            comments.PrintComments();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}