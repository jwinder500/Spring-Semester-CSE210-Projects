using System;

namespace Develop05
{
    public class Progress_Goal:Goal
    {
        private List<string> Progress_Goals = new List<string>();
        private List<string> Small_Goals = new List<string>();
        private List<int> Small_Points = new List<int>();
        //These list is for any progress goals
        public override void CreateGoal()
        {
            //This creates a goal for the user

            Console.WriteLine("What Goal are you interested in?");
            string goal = Console.ReadLine();
            Progress_Goals.Add(goal);

            Console.WriteLine("How many points is it worth");
            string _point = Console.ReadLine();
            int point = int.Parse(_point);

            Console.WriteLine("How many types of goals do you need to set to reach it?");
            int goals = int.Parse(Console.ReadLine());

            for (int g = goals; g > 0; g --)
            {
                Console.WriteLine("What Progress Goal do you want to set?");
                string pgoal = Console.ReadLine();
                Small_Goals.Add(pgoal);

                Console.WriteLine("How many points is it worth");
                int points = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            SaveGoal(goal, point);
            Console.WriteLine();
        }

        public override int CompleteGoal()
        {
            //This function moves a goal from the goal list to the completed list

            Console.WriteLine("Which goal did you complete?");
            string goal = Console.ReadLine();
            int points = 0;
            
            foreach (string g in Progress_Goals)
            {
                if (g == goal)
                {
                    int index = Goals.IndexOf($"{g}");
                    points = Points[index];

                    Completed.Add(g);
                    Goals.RemoveAt(index);
                    Points.RemoveAt(index);
                    Progress_Goals.RemoveAt(Progress_Goals.IndexOf(g));
                    break;
                }
            }
            foreach (string g in Small_Goals)
            {
                if (g == goal)
                {
                    int index = Small_Goals.IndexOf(goal);
                    points = Small_Points[index];

                    Completed.Add(goal);
                    Small_Goals.RemoveAt(index);
                    Small_Points.RemoveAt(index);

                    break;
                }
            }
            Console.WriteLine();
            return points;
        }
    }
}