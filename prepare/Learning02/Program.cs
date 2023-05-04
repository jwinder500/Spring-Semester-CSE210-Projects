using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._Title = "Construction";
        Job1._Company = "Heights";
        Job1._Start = 2016;
        Job1._End = 2022;

        Job Job2 = new Job();
        Job2._Title = "Intern";
        Job2._Company = "Somewhere";
        Job2._Start = 2022;
        Job2._End = 2023;

        Resume PersonResume = new Resume();
        PersonResume._Name = "James Winder";
        PersonResume._jobs.Add(Job1);
        PersonResume._jobs.Add(Job2);
        PersonResume.Display();

    }
}