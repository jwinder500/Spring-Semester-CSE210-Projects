using System;

namespace Develop04
{
    public class Listening:Activity
    {
        public void runListening()
        {
            //This class runs the listening exercise
            getWelcome(activity);

            getDescription(description);
            // this tells the person what they will be doing for the excercise

            Console.WriteLine(askTime);
            string duration = Console.ReadLine();
            int time = getDuration(duration);
            //This gets the total time for the exercise

            getReady();

            Console.WriteLine();
            Console.WriteLine("List as many responses you can to the followint prompt");
            //Tells user what to do

            prompts2.addPrompts(prompt);
            prompts2.selectRandomPrompt();

            getReady();

            while(time >= 0)
            {
                addItem();
                timeKeeping.spinner();
                time -= 4;
            }

            getFinalMessage(activity);
        }
        private string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        private string activity = "Listening";
        //This is some of the variables used in the run listening function

        private void addItem()
        {
            Console.ReadLine();
        }
        private List<string> prompt = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal stregnths of yours?",
            "Who are the people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        //This is a list of the peompts a person could recieve
    }
}