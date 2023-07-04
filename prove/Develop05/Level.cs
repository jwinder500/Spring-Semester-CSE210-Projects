using System;

namespace Develop05
{
    public class Level
    {
        public int FindLevel(int points)
        {
            // finds level of user
            float number = points / 1000;
            int level = (int)Math.Round(number);
            if (level >= 1)
            {
                level = 1;
            }
            return level;
        }
    }
}