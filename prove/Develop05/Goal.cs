using System;

namespace Develop05
{
    public class Goal
    {
        //This class is for adjusting any goals
        private List<string> Goals = new List<string>();
        private List<string> Completed = new List<string>();
        //These lists can be used by this class or  any class below it

        public virtual void CreateGoal()
        {
            
        }
        protected void SaveGoal(string goal)
        {
            //this function adds a goal to the list of Goals

            Goals.Add(goal);
        }
        public void CompleteGoal(string goal)
        {
            //This function moves a goal from the goal list to the completed list

            Console.WriteLine("Which goal did you complete");
            goal = Console.ReadLine();
            foreach (string g in Goals)
            {
                if (g == goal)
                {
                    int index = Goals.IndexOf($"{g}");
                    Completed.Add(g);
                    Goals.RemoveAt(index);
                }
            }
        }
        public void DisplayGoal()
        {
            foreach (string goal in Goals)
            {
                Console.WriteLine(goal);
            }
        }
        public void DisplayCompleted()
        {
            foreach (string goal in Completed)
            {
                Console.WriteLine(goal);
            }
        }
    }
}