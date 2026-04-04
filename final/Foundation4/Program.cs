using System;

namespace ExerciseProgram
{
    class Activity
    {
        protected string Date;
        protected int Minutes;

        public Activity(string date, int minutes)
        {
            Date = date;
            Minutes = minutes;
        }

        public virtual double GetDistance() { return 0; }
        public virtual double GetSpeed() { return 0; }
        public virtual double GetPace() { return 0; }

        public string GetSummary()
        {
            return $"{Date} {GetType().Name} ({Minutes} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
        }
    }

    class Running : Activity
    {
        private double Distance;

        public Running(string date, int minutes, double distance)
            : base(date, minutes)
        {
            Distance = distance;
        }

        public override double GetDistance() => Distance;
        public override double GetSpeed() => (Distance / Minutes) * 60;
        public override double GetPace() => Minutes / Distance;
    }

    class Cycling : Activity
    {
        private double Speed;

        public Cycling(string date, int minutes, double speed)
            : base(date, minutes)
        {
            Speed = speed;
        }

        public override double GetSpeed() => Speed;
        public override double GetDistance() => (Speed / 60) * Minutes;
        public override double GetPace() => 60 / Speed;
    }

    class Swimming : Activity
    {
        private int Laps;

        public Swimming(string date, int minutes, int laps)
            : base(date, minutes)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            return Laps * 50 / 1000.0 * 0.62; // miles
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / GetDistance();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running("03 Nov 2022", 30, 3.0),
                new Cycling("04 Nov 2022", 45, 12.0),
                new Swimming("05 Nov 2022", 40, 20)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}