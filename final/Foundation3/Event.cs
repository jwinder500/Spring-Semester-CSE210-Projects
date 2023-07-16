using System;

namespace Foundation3
{
    public class Event
    {
        protected string title;
        protected string description;
        public string date(int day, int month, int year)
        {
            string strmonth = month.ToString();
            string strday = day.ToString();
            string stryear = year.ToString();
            protected string MMDDYY = $"{strmonth}/{strday}/{stryear}";
            return MMDDYY;
        }
        protected string time()
        {

        }
        protected string address;
    }
}