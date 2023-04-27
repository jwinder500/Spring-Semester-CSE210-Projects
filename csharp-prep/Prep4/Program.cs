using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int guess = 1;
        int sum = 0;
        int average = 0;
        int number = 0;
        int largest = -999999999;
        while (guess != 0)
        {
            Console.WriteLine("Enter a number: ");
            guess = int.Parse(Console.ReadLine());
            if (guess != 0)
            {
                sum += guess;
                number += 1;
                average = sum / number;
                if (guess > largest)
                {
                    largest = guess;
                }
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}