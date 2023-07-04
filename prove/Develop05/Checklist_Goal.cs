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
            string _point = Console.ReadLine();
            int point = int.Parse(_point);

            Console.WriteLine("How many times do you need to get it done?");
            string _repeat = Console.ReadLine();
            int repeat = int.Parse(_point);

            for(int i = 0; i < repeat; i++)
            {
                SaveGoal($"{goal}", point);
            }
        }

        public override void CompleteGoal()
        {
            //This function moves a goal from the goal list to the completed list

            Console.WriteLine("Which checklist goal did you complete?");
            string goal = Console.ReadLine();
            
            foreach (string g in Checklist_Goals)
            {
                if (g == goal)
                {
                    int index = Goals.IndexOf(g);
                    int New_Points = Points[index];

                    Completed.Add(g);
                    Goals.RemoveAt(index);
                    Points.RemoveAt(index);
                    Checklist_Goals.RemoveAt(Checklist_Goals.IndexOf(g));
                    
                    int score = points.AddPoints(New_Points);
                    Console.WriteLine(score);
                    break;
                }
            }
        }
    }
}