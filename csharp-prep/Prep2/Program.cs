using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "0";
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (number >= 70)
        {
            Console.WriteLine($"Congragulations you passed, your letter grade is: {letter}");
        }
        else
        {
            Console.WriteLine($"You failed, your letter grade is: {letter}");
            Console.WriteLine("Better luck next time");
        }
    }
}