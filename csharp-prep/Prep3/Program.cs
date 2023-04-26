using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "Y";
        while (response == "Y")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,101);
            string correct = "Wrong";
            while (correct == "Wrong")
            {
                Console.WriteLine("What is the magic number");
                int guess = int.Parse(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    correct = "Right";
                }
            }
            Console.WriteLine("Do you want to continue? (Y/N)");
            response = Console.ReadLine();
        }
    Console.WriteLine("Have A Great Day!");
    }
}