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

            SaveGoal(goal, point);
        }
        protected void SaveGoal(string goal, int point)
        {
            //this function adds a goal to the list of Goals

            Points.Add(point);
            Goals.Add(goal);
        }
        public virtual int CompleteGoal()
        {
            //This function moves a goal from the goal list to the completed list

            Console.WriteLine("Which goal did you complete?");
            string goal = Console.ReadLine();
            Console.WriteLine();
            int points = 0;
            foreach (string g in Goals)
            {
                if (g == goal)
                {
                    int index = Goals.IndexOf(g);
                    points = Points[index];

                    Completed.Add(g);
                    Goals.RemoveAt(index);
                    Points.RemoveAt(index);

                    break;
                }
            }
            return points;
        }
        public void DisplayGoals()
        {
            // This displays the goals for the user

            foreach (string goal in Goals)
            {
                Console.WriteLine(goal);
            }
            Console.WriteLine();
        }
        public void DisplayCompleted()
        {
            // this displays everythihg that the user completed

            foreach (string goal in Completed)
            {
                Console.WriteLine(goal);
            }
            Console.WriteLine();
        }
    }
}