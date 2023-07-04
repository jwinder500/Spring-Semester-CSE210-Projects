using System;

namespace Develop05
{
    public class Checklist_Goal:Goal
    {
        private List<string> Checklist_Goals = new List<string>();
        //This list is for checklist goals
        public override void CreateGoal()
        {
            //This revises a few things
            
            Console.WriteLine("What is your new checkilst goal?");
            string goal = Console.ReadLine();
            Checklist_Goals.Add(goal);

            Console.WriteLine("How many points is it worth?");
            int point = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times do you need to get it done?");
            int repeat = int.Parse(Console.ReadLine());

            for(int i = 0; i < repeat; i++)
            {
                SaveGoal(goal, point);
            }
            Console.WriteLine();
        }

        public override int CompleteGoal()
        {
            //This function moves a goal from the goal list to the completed list

            Console.WriteLine("Which checklist goal did you complete?");
            string goal = Console.ReadLine();
            int points = 0;
            
            foreach (string g in Checklist_Goals)
            {
                if (g == goal)
                {
                    int index = Goals.IndexOf(goal);
                    points = Points[index];

                    Completed.Add(goal);
                    Goals.RemoveAt(index);
                    Points.RemoveAt(index);
                    Checklist_Goals.RemoveAt(Checklist_Goals.IndexOf(g));
                    
                    break;
                }
            }
            Console.WriteLine();
            return points;
        }
    }
}