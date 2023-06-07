using System;

namespace Develop04
{
    public class Listening:Activity
    {
        public void runListening()
        {
            //This class runs the breathing exercise
            getWelcome(activity);

            getDescription(description);
            // this tells the person what they will be doing for the excercise

            Console.WriteLine(askTime);
            string duration = Console.ReadLine();
            int time = getDuration(duration);
            //This gets the total time for the exercise

            while(time >= 0)
            {

            }

            getFinalMessage(activity);
        }
        string description = "";
        string activity = "Listening";
        //This is some of the variables used in the run listening function
    }
}