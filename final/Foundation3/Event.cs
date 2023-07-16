using System;

namespace Foundation3
{
    public class Event
    {
        protected string title;
        protected string description;
        protected string date(int day, int month, int year)
        {
            protected string MMDDYY = $"{month}/{day}/{year}";
            return MMDDYY;
        }
        protected int time;
        protected string address;
    }
}