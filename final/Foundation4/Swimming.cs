using System;

namespace Foundation4
{
    class Swimming:Activity
    {
        public override string GetSummary()
        {
            string summary = $"{date(15, 06, 2023)} {activity()}({time(10)})- Distance: {distance(30, 0)} KM, Speed: {speed(distance(30, 0), time(10))} KPH, Pace: {pace(distance(30, 0), time(10))} min per KM.";
            return summary;
        }
        protected override int distance(int laps, int somethingelse)
        {
            int Distance = (laps * 50) / 1000;
            return Distance;
        }
        protected override int speed(int speed, int somethingelse)
        {
            int Speed = speed;
            return Speed;
        }
        protected override int pace(int pace, int somethingelse)
        {
            int Pace = pace;
            return Pace;
        }
        protected override string activity()
        {
            string activity = "Swimming";
            return activity;
        }
    }

}