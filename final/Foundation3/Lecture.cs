using System;

namespace Foundation3
{
    public class Lecture:Event
    {
        private string name = "President Eyering";
        private int capacity = 15000;
        protected override string title()
        {
            string title = "Devotional";
            return title;
        }
        protected override string description()
        {
            string descrition = $"This weeks {title()}";
            return descrition;
        }
        protected override string address()
        {
            string address = "50 W. Viking Drive, Rexburg, ID 83440";
            return address;
        }
        
        public void run(int number)
        {
            string details = "";
            if (number == 0)
            {
                details = $"This weeks {title()} is on {date(11,11,24)}";
                
            }
            else if (number == 1)
            {
                details = $"{title()}, {description()}, it is on {date(11,11,24)}, at{time(12, 30)} at the I center which is at {address()}";
                
            }
            else if (number == 2)
            {
                details = details = $"{title()}, {description()}, with {name},it is on {date(11,11,24)}, at{time(12, 30)} at the I center which is at {address()}, the capacity is {capacity}";
                
            }
            Console.WriteLine(details);
        }
    }
}