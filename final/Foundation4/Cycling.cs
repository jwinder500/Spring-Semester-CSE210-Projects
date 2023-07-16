using System;

namespace Foundation4
{
    class Cycling:Activity
    {
        public override string GetSummary()
        {
            string summary = $"{date(15, 06, 2023)} {activity()}({time(40)})- Distance: {distance(speed(6,0), time(40))} KM, Speed: {speed(6,0)} KPH, Pace: {pace(speed(6,0),0)} min per KM.";
            return summary;
        }
        protected override int distance(int speed, int time)
        {
            int Distance = speed * time / 60;
            return Distance;
        }
        protected override int speed(int speed, int somethingelse)
        {
            int Speed = speed;
            return Speed;
        }
        protected override int pace(int speed, int somethingelse)
        {
            int Pace = 60 / speed;
            return Pace;
        }
        protected override string activity()
        {
            string activity = "Cycling";
            return activity;
        }
    }

}