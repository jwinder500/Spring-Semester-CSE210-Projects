using System;

namespace Develop05
{
    public class Points
    {
        public int points;
        public int AddPoints(int point)
        {
            // This adds points every time a goal is completed

            points += point;
            return points;
        }
        
        public void DisplayPoints()
        {
            //This shows the user's points
            
            Console.WriteLine("Total Points:");
            Console.WriteLine($"{points}");
        }
    }
}