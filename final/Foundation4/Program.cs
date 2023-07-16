using System;

namespace Foundation4
{
    class Program
    {
        static void Main(string[] args)
        {
            Running running = new Running();
            Swimming swimming = new Swimming();
            Cycling cycling = new Cycling();

            Console.WriteLine(running.GetSummary());
            Console.WriteLine(swimming.GetSummary());
            Console.WriteLine(cycling.GetSummary());
        }
    }
}