using System;

namespace Foundation3
{
    public class Outdoor:Event
    {
        private string weather = "cold, what did you expect for Idaho!!!";
        protected override string title()
        {
            string title = "Skiing trip.";
            return title;
        }
        protected override string description()
        {
            string descrition = $"This weeks {title()} will be an amazing visit to a ski resort";
            return descrition;
        }
        protected override string address()
        {
            string address = "20934 E. Mountainview Dr. Cold City, ID, 83029";
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
                details = $"{title()}, {description()}, it is on {date(11,11,24)}, at{time(12, 30)} at {address()}";
                
            }
            else if (number == 2)
            {
                details = details = $"{title()}, {description()}, it is on {date(11,11,24)}, at{time(12, 30)}at {address()}, the weather will be {weather}";
                
            }
            Console.WriteLine(details);
        }
    }
}