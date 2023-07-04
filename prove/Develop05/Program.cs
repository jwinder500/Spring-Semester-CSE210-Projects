using System;
using System.Collections.Generic;

namespace Develop05
{
    public class Program
    {
        static void Main(string[] args)
        {
            //this class puts it all together
            Goal goal = new Goal();
            Level level = new Level();
            Eternal_Goal eternal = new Eternal_Goal();
            Checklist_Goal checklist = new Checklist_Goal();
            Progress_Goal progress = new Progress_Goal();

            int Keep_Going = 1;
            while (Keep_Going != 0)
            {               
                //menu
                Console.WriteLine();
                Console.WriteLine("What would you like to do today? ");
                Console.WriteLine("0: Quit. ");
                Console.WriteLine("1: Create a Goal. ");
                Console.WriteLine("2: View all Goals. ");
                Console.WriteLine("3: Complete a Goal. ");
                Console.WriteLine("4: View your level. ");
                Console.WriteLine("5: View Points. ");
                Console.WriteLine();

                //selection
                string selection = Console.ReadLine();
                Keep_Going = int.Parse(selection);

                //what to do based on selection
                if (Keep_Going == 1)
                {
                    int selection2 = 0;

                    //menu for creating a goal
                    Console.WriteLine();
                    Console.WriteLine("What type of goal would you like to create? ");
                    Console.WriteLine("1. Regular. ");
                    Console.WriteLine("2. Eternal. ");
                    Console.WriteLine("3. Checklist. ");
                    Console.WriteLine("4. Progress. ");
                    Console.WriteLine();

                    string answer = Console.ReadLine();
                    selection2 = int.Parse(answer);

                    if (selection2 == 1)
                    {
                        goal.CreateGoal();
                    }
                    else if (selection2 == 2)
                    {
                        eternal.CreateGoal();
                    }
                    else if (selection2 == 3)
                    {
                        checklist.CreateGoal();
                    }
                    else if (selection2 == 4)
                    {
                        progress.CreateGoal();
                    }
                    else
                    {
                        Console.WriteLine("Try a different number.");
                    }

                }
                else if (Keep_Going == 2)
                {
                    goal.DisplayGoals();
                }
                else if (Keep_Going == 3)
                {
                    int selection3 = 0;
                    
                    //Completion menu
                    Console.WriteLine();
                    Console.WriteLine("What type of goal would you like to complete? ");
                    Console.WriteLine("1. Regular. ");
                    Console.WriteLine("2. Eternal. ");
                    Console.WriteLine("3. Checklist. ");
                    Console.WriteLine("4. Progress. ");
                    Console.WriteLine();

                    string answer = Console.ReadLine();
                    selection3 = int.Parse(answer);

                    if (selection3 == 1)
                    {
                        
                        goal.CompleteGoal();
                    }
                    else if (selection3 == 2)
                    {
                        eternal.CompleteGoal();
                    }
                    else if (selection3 == 3)
                    {
                        checklist.CompleteGoal();
                    }
                    else if (selection3 == 4)
                    {
                        progress.CompleteGoal();
                    }
                    else
                    {
                        Console.WriteLine("Try a different number.");
                    }
                }
                else if (Keep_Going == 4)
                {
                    int point = goal.FindPoints();
                    level.FindLevel(point);
                    Console.WriteLine($"Level: {level}");
                }
                else if (Keep_Going == 5)
                {
                    int point = goal.FindPoints();
                    Console.WriteLine($"Points: {point}");
                }
                else
                {
                    Console.WriteLine("Try a different number.");
                }
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}