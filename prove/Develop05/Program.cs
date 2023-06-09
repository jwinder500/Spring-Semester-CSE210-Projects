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
            Points points = new Points();

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
                Keep_Going = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //what to do based on selection
                if (Keep_Going == 1)
                {
                    int selection = 0;

                    //menu for creating a goal
                    Console.WriteLine();
                    Console.WriteLine("What type of goal would you like to create? ");
                    Console.WriteLine("1. Regular. ");
                    Console.WriteLine("2. Eternal. ");
                    Console.WriteLine("3. Checklist. ");
                    Console.WriteLine("4. Progress. ");
                    Console.WriteLine();

                    selection = int.Parse(Console.ReadLine());

                    if (selection == 1)
                    {
                        goal.CreateGoal();
                    }
                    else if (selection == 2)
                    {
                        eternal.CreateGoal();
                    }
                    else if (selection == 3)
                    {
                        checklist.CreateGoal();
                    }
                    else if (selection == 4)
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
                    Console.WriteLine();
                    Console.WriteLine("Which goals would you like to see? ");
                    Console.WriteLine("1: Goals to be done");
                    Console.WriteLine("2: Completed goals");
                    Console.WriteLine();

                    int selection1 = int.Parse(Console.ReadLine());

                    if (selection1 == 1)
                    {
                        int selection3 = 0;
                        Console.WriteLine();
                        Console.WriteLine("What type of goal would you like to view? ");
                        Console.WriteLine("1. Regular. ");
                        Console.WriteLine("2. Eternal. ");
                        Console.WriteLine("3. Checklist. ");
                        Console.WriteLine("4. Progress. ");
                        Console.WriteLine();
                        selection3 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (selection3 == 1)
                        {
                            goal.DisplayGoals();
                        }
                        else if (selection3 == 2)
                        {
                            eternal.DisplayGoals();
                        }
                        else if (selection3 == 3)
                        {
                            checklist.DisplayGoals();
                        }
                        else if (selection3 == 4)
                        {
                            progress.DisplayGoals();
                        }
                        else
                        {
                            Console.WriteLine("Try a different number.");
                        }
                    }
                    else if (selection1 == 2)
                    {
                        int selection4 = 0;
                        Console.WriteLine();
                        Console.WriteLine("What type of goal would you like to view? ");
                        Console.WriteLine("1. Regular. ");
                        Console.WriteLine("2. Eternal. ");
                        Console.WriteLine("3. Checklist. ");
                        Console.WriteLine("4. Progress. ");
                        Console.WriteLine();
                        selection4 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (selection4 == 1)
                        {
                            goal.DisplayCompleted();
                        }
                        else if (selection4 == 2)
                        {
                            eternal.DisplayCompleted();
                        }
                        else if (selection4 == 3)
                        {
                            checklist.DisplayCompleted();
                        }
                        else if (selection4 == 4)
                        {
                            progress.DisplayCompleted();
                        }
                        else
                        {
                            Console.WriteLine("Try a different number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try a different number.");
                    }
                }
                else if (Keep_Going == 3)
                {
                    int selection2 = 0;
                    
                    //Completion menu
                    Console.WriteLine();
                    Console.WriteLine("What type of goal would you like to complete? ");
                    Console.WriteLine("1. Regular. ");
                    Console.WriteLine("2. Eternal. ");
                    Console.WriteLine("3. Checklist. ");
                    Console.WriteLine("4. Progress. ");
                    Console.WriteLine();

                    selection2 = int.Parse(Console.ReadLine());

                    if (selection2 == 1)
                    {
                        
                        points.AddPoints(goal.CompleteGoal());
                    }
                    else if (selection2 == 2)
                    {
                        points.AddPoints(eternal.CompleteGoal());
                    }
                    else if (selection2 == 3)
                    {
                        points.AddPoints(checklist.CompleteGoal());
                    }
                    else if (selection2 == 4)
                    {
                        points.AddPoints(progress.CompleteGoal());
                    }
                    else
                    {
                        Console.WriteLine("Try a different number.");
                    }
                }
                else if (Keep_Going == 4)
                {
                    level.FindLevel(points.AddPoints(0));
                    Console.WriteLine($"Level: {level}");
                }
                else if (Keep_Going == 5)
                {
                    int point = points.AddPoints(0);
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