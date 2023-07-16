using System;

namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture lecture = new Lecture();
            Reception reception = new Reception();
            Outdoor outdoor = new Outdoor();
            int escape = 1;

            while (escape != 0)
            {
                Console.WriteLine();
                Console.WriteLine("What event would you like to see ?");
                Console.WriteLine();
                Console.WriteLine("1. Devotional");
                Console.WriteLine("2. Reception");
                Console.WriteLine("3. Ski trip");
                Console.WriteLine("4. Quit");
                Console.WriteLine();

                string response = Console.ReadLine();
                escape =  int.Parse(response);
                if (escape == 1)
                {
                    int detailType = 0;
                    Console.WriteLine("What kind of details do you want?");
                    Console.WriteLine();
                    Console.WriteLine("1. Short description");
                    Console.WriteLine("2. Standard description");
                    Console.WriteLine("3. Full description");
                    Console.WriteLine();
                    response = Console.ReadLine();
                    detailType =  int.Parse(response);
                    Console.WriteLine();

                    lecture.run(detailType - 1);
                }
                else if (escape == 2)
                {
                    int detailType = 0;
                    Console.WriteLine("What kind of details do you want?");
                    Console.WriteLine();
                    Console.WriteLine("1. Short description");
                    Console.WriteLine("2. Standard description");
                    Console.WriteLine("3. Full description");
                    Console.WriteLine();
                    response = Console.ReadLine();
                    detailType =  int.Parse(response);
                    Console.WriteLine();

                    reception.run(detailType - 1);
                }
                else if (escape == 3)
                {
                    int detailType = 0;
                    Console.WriteLine("What kind of details do you want?");
                    Console.WriteLine();
                    Console.WriteLine("1. Short description");
                    Console.WriteLine("2. Standard description");
                    Console.WriteLine("3. Full description");
                    Console.WriteLine();
                    response = Console.ReadLine();
                    detailType =  int.Parse(response);
                    Console.WriteLine();

                    outdoor.run(detailType - 1);
                }
                else
                {
                    escape = 0;
                }
            }
        }
    }
}