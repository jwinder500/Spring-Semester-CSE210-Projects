using System;

namespace Foundation4
{
    class Running:Activity
    {
        public override string GetSummary()
        {
            string summary = $"{date(15, 06, 2023)} {activity()}({time(60)})- Distance: {distance(8,0)} KM, Speed: {speed(distance(8,0), time(60))} KPH, Pace: {pace(distance(8,0), time(60))} min per KM.";
            return summary;
        }
        protected override int distance(int distance, int somethingelse)
        {
            int Distance = distance;
            return Distance;
        }
        protected override int speed(int distance, int time)
        {
            int Speed = (distance / time) * 60;
            return Speed;
        }
        protected override int pace(int distance, int time)
        {
            int Pace = (time/distance);
            return Pace;
        }
        protected override string activity()
        {
            string activity = "Running";
            return activity;
        }
    }

}