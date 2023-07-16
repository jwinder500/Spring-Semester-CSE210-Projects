using System;

namespace Foundation3
{
    public class Reception:Event
    {
        private string email = "ihaveanemail@gmail.com";
        protected override string title()
        {
            string title = "Reception";
            return title;
        }
        protected override string description()
        {
            string descrition = $"This weeks {title()}, there will be plenty of fun activities including a pool table";
            return descrition;
        }
        protected override string address()
        {
            string address = "5000 W. Reception place, Rexburg, ID 83440";
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
                details = $"{title()}, {description()}, it is on {date(11,11,24)}, at{time(12, 30)}, at {address()}";
            }
            else if (number == 2)
            {
                details = $"{title()}, {description()}, it is on {date(11,11,24)}, at{time(12, 30)} at {address()}, email {email} to RSVP";
            }
            Console.WriteLine(details);
        }
    }
}