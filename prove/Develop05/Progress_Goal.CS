using System;

namespace Develop05
{
    public class Progress:Goal
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
            string _goal = Console.ReadLine();
            int goals = int.Parse(_goal);

            for (int g; goals <= 0; goals --)
            {
                g = goals;
                Console.WriteLine("What Progress Goal do you want to set?");
                string pgoal = Console.ReadLine();
                Small_Goals.Add(pgoal);

                Console.WriteLine("How many points is it worth");
                string _points = Console.ReadLine();
                int points = int.Parse(_point);
            }

            SaveGoal($"{goal}", point);
        }

        public override void CompleteGoal(string goal)
        {
            //This function moves a goal from the goal list to the completed list

            Console.WriteLine("Which goal did you complete?");
            goal = Console.ReadLine();
            foreach (string g in Progress_Goals)
            {
                if (g == goal)
                {
                    int index = Goals.IndexOf($"{g}");
                    int New_Points = Points[index];

                    Completed.Add(g);
                    Goals.RemoveAt(index);
                    Points.RemoveAt(index);
                    Progress_Goals.RemoveAt(Progress_Goals.IndexOf(g));

                    int score = points.AddPoints(New_Points);
                    Console.WriteLine(score);
                    break;
                }
            }
            foreach (string g in Small_Goals)
            {
                if (g == goal)
                {
                    int index = Small_Goals.IndexOf($"{g}");
                    int New_Points = Small_Points[index];

                    Completed.Add(g);
                    Small_Goals.RemoveAt(index);
                    Small_Points.RemoveAt(index);

                    int score = points.AddPoints(New_Points);
                    Console.WriteLine(score);
                    break;
                }
            }
        }
    }
}