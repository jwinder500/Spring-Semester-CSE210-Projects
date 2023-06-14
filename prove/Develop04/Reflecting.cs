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

            prompts.addPrompts(prompt);
            prompts.selectRandomPrompt();
            //This gets a prompt for the user

            questions.addPrompts(question);
            //This adds questions to be used in the clsss
            
            Console.WriteLine(askTime);
            string duration = Console.ReadLine();
            int time = getDuration(duration);
            //This gets the total time for the exercise

            getReady();

            Console.WriteLine("Now ponder on each of the following questions as they relate to this expirience");
            //This tells the user what to do
            Console.WriteLine("You may begin in:");
            timeKeeping.countdown(5);

            while(time >= 0)
            {
                Console.WriteLine();
                Console.WriteLine(prompts.selectRandomPrompt());
                timeKeeping.spinner();
                time -= 4;
                timeKeeping.spinner();
                time -= 4;
            }

            getFinalMessage(activity);
        }
        private string description = "For this Activity you will ponder a few questions related to something that you did.";
        private string activity = "Reflecting";
        //This is some of the variables used in the run reflecting function

        private List<string> prompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        //This is the list of prompts that a user can get

        private List<string> question = new List<string>
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
        //This is a list of questions related to what the user got for their prompt
    }
}