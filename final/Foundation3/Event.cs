using System;

namespace Foundation3
{
    public class Event
    {
        protected virtual string title()
        {
            string title = "Event";
            return title;
        }
        protected virtual string description()
        {
            string descrition = "description";
            return descrition;
        }
        public string date(int day, int month, int year)
        {
            string MMDDYY = $"{month}/{day}/{year}";
            return MMDDYY;
        }
        public string time(int hour, int min)
        {
            string time = $"{hour}:{min}";
            return time;
        }
        protected virtual string address()
        {
            string address = "address";
            return address;
        }
    }
}