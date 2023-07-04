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
            
            SaveGoal(goal, point);
            Console.WriteLine();
        }
        
        public override int CompleteGoal()
        {
            //This function moves a goal from the goal list to the completed list

            Console.WriteLine("Which Eternal Goal did you complete? ");
            string goal = Console.ReadLine();
            int points = 0;
            
            foreach (string g in Eternal_Goals)
            {
                if (g == goal)
                {
                    int index = Goals.IndexOf(goal);
                    points = Points[index];
                    Completed.Add(goal);
                    break;
                }
            }
            Console.WriteLine();
            return points;
        }
    }
}