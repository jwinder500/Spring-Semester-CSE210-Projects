using System;

namespace Foundation4
{
    class Activity
    {
        public virtual string GetSummary()
        {
            string summary = $"{date(15, 06, 2023)}, {activity()}- Distance: {distance(3, 0)} KM, Speed: {speed(6, 0)} KPH, Pace: {pace(10, 0)} min per KM.";
            return summary;
        }
        protected string date(int day, int month, int year)
        {
            string MMDDYY = $"{month}/{day}/{year}";
            return MMDDYY;
        }
        protected virtual string activity()
        {
            string activity = "Activity";
            return activity;
        }
        protected int time(int time)
        {
            int Time = time;
            return Time;
        }
        protected virtual int distance(int distance, int somethingelse)
        {
            int Distance = distance;
            return Distance;
        }
        protected virtual int speed(int speed, int somethingelse)
        {
            int Speed = speed;
            return Speed;
        }
        protected virtual int pace(int pace, int somethingelse)
        {
            int Pace = pace;
            return Pace;
        }
    }

}