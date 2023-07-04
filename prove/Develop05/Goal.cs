using System;

namespace Develop05
{
    public class Goal
    {
        //This class is for adjusting any goals
        protected List<string> Goals = new List<string>();
        protected List<string> Completed = new List<string>();
        protected List<int> Points = new List<int>();
        //These lists can be used by this class or  any class below it

        public virtual void CreateGoal()
        {
            //This creates a goal for the user

            Console.WriteLine("What goal are you interested in?");
            string goal = Console.ReadLine();

            Console.WriteLine("How many points is it worth");
            string _point = Console.ReadLine();
            int point = int.Parse(_point);

            SaveGoal($"{goal}", point);
        }
        protected void SaveGoal(string goal, int point)
        {
            //this function adds a goal to the list of Goals

            Points.Add(point);
            Goals.Add(goal);
        }
        public virtual void CompleteGoal(string goal)
        {
            //This function moves a goal from the goal list to the completed list

            Console.WriteLine("Which goal did you complete?");
            goal = Console.ReadLine();
            foreach (string g in Goals)
            {
                if (g == goal)
                {
                    int index = Goals.IndexOf($"{g}");
                    int New_Points = Points[index];

                    Completed.Add(g);
                    Goals.RemoveAt(index);
                    Points.RemoveAt(index);

                    int score = points.AddPoints(New_Points);
                    Console.WriteLine(score);
                    break;
                }
            }
        }
        public void DisplayGoals()
        {
            // This displays the goals for the user

            foreach (string goal in Goals)
            {
                Console.WriteLine(goal);
            }
        }
        public void DisplayCompleted()
        {
            // this displays everythihg that the user completed

            foreach (string goal in Completed)
            {
                Console.WriteLine(goal);
            }
        }
    }
}