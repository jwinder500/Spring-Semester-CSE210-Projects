using System;

namespace Develop04
{
    public class Breathing:Activity
    {
        public void runBreathing()
        {
            //This class runs the breathing exercise

            getWelcome(activity);
            //welcomes user to breath in and out

            getDescription(description);
            // this tells the person what they will be doing for the excercise

            Console.WriteLine(askTime);
            string duration = Console.ReadLine();
            int time = getDuration(duration);
            //This gets the total time for the exercise

            getReady();

            while(time >= 0)
            {
                //this is where the actual breathing exercise starts
                Console.WriteLine("Breathe in");
                timeKeeping.countdown(4);
                Console.WriteLine("Breathe out");
                timeKeeping.countdown(6);
                time -= 10;
                //this will repeat untill the time runs out
            }

            getFinalMessage(activity);
        }
        private string description = "This program will walk you through a breathing exercise";
        private string activity = "Breathing";
        //This is some of the variables used in the run breathing function
    }
}