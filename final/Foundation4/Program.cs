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

            running.GetSummary();
            swimming.GetSummary();
            cycling.GetSummary();
        }
    }
}