using System;

namespace Develop04
{
    public class Activity
    {
        //This class runs all activity related items

        protected Timer timeKeeping = new Timer();
        //This helpes keep track of time

        protected string getWelcome(string activity)
        {
            string welcomeMessage = $"Welcome to the {activity} Activity";
            return welcomeMessage;
            //This is the message the user will see asking for the time
        }

        protected string getDescription(string description)
        {
            return description;
            //this is where it describes activity
        }

        protected int getDuration(string activityTime)
        {
            string duration = activityTime;
            int remaining = int.Parse(duration);
            return remaining;
            //This is the time it takes for the activity to countdown
        }

        protected string getFinalMessage(string activity)
        {
            string finalMessage = $"Congragulations you have completed the {activity} Activity!!!";
            return finalMessage;
            //this is where the final message can show up
        }
        protected string askTime = "How long would you like to do this activity? (Seconds)";

        protected void getReady()
        {
            Console.WriteLine("Get Ready");
            timeKeeping.dotdotdot(3);
        }
    }
}