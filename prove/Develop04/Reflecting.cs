using System;

namespace Develop04
{
    public class Reflecting:Activity
    {
        public void runReflecting()
        {
            //This class runs the breathing exercise

            getWelcome(activity);
            // Welcomes user to activity

            getDescription(description);
            // this tells the person what they will be doing for the excercise

            Console.WriteLine(askTime);
            string duration = Console.ReadLine();
            int time = getDuration(duration);
            //This gets the total time for the exercise

            getReady();


            while(time >= 0)
            {
                
            }

            getFinalMessage(activity);
        }
        private string description = "";
        private string activity = "Reflecting";
        //This is some of the variables used in the run reflecting function

        private List<string> prompt = new List<string>
        {
            "",
            "",
            "",
            ""
        };

        private List<string> questions = new List<string>
        {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
        };

    }
}