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
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> questions = new List<string>
        {
            "Why was this expiriance meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this expirience?",
            "What could you learn from this expirience that applies to other situations?",
            "What did you learn about yourself through this expirience?",
            "How can you keep this expirience in mind in the future?"
        };
    }
}