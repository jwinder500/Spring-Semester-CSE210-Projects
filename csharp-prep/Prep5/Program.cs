using System;

class Program
{
    static void Main(string[] args)
    {
        welcome();
        string username = findname();
        int findingnumber = findnumber();
        int squared = numbersquared(findingnumber);

        reply(username, squared);
    }
    static void welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string findname()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int findnumber()
    {
        Console.WriteLine("Please enter your favorite number");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int numbersquared(int number)
    {
        int square = number * number;
        return square;
    }
    static void reply(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }   
}