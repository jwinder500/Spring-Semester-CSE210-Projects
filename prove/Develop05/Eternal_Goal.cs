using System;

namespace Develop05
{
    public class Eternal_Goal:Goal
    {
        private List<string> Eternal_Goals = new List<string>();
        //List for eternal goals
        public override void CreateGoal()
        {
            //This revises a few things in the method
            
            Console.WriteLine("What is your new Eternal Goal?");
            string goal = Console.ReadLine();
            Eternal_Goals.Add(goal);

            Console.WriteLine("How many points is it worth?(Make it Big!!!)");
            string _point = Console.ReadLine();
            int point = int.Parse(_point);
            
            SaveGoal($"{goal}", point);
        }
        
        public override void CompleteGoal(string goal)
        {
            //This function moves a goal from the goal list to the completed list

            Console.WriteLine("Which Eternal Goal did you complete");
            goal = Console.ReadLine();
            foreach (string g in Eternal_Goals)
            {
                if (g == goal)
                {
                    int index = Goals.IndexOf($"{g}");
                    int New_Points = Points[index];
                    Completed.Add(g);
                    int score = points.AddPoints(New_Points);
                    Console.WriteLine(score);
                    break;
                }
            }
        }
    }
}