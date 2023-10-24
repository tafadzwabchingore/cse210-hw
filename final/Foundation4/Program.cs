using System;

public class Activity
{
    private DateTime startTime;
    private DateTime endTime;
    private double distance;

    public Activity(DateTime startTime, DateTime endTime, double distance)
    {
        this.startTime = startTime;
        this.endTime = endTime;
        this.distance = distance;
    }

    public virtual double GetDistance()
    {
        return distance;
    }

    public virtual double GetSpeed()
    {
        return distance / (endTime - startTime).TotalHours;
    }

    public virtual TimeSpan GetPace()
    {
        return TimeSpan.FromMinutes((endTime - startTime).TotalMinutes / distance);
    }

    public virtual string GetSummary()
    {
        return $"Activity started at {startTime}, ended at {endTime}, distance covered: {distance} km, speed: {GetSpeed()} km/h, pace: {GetPace()} min/km";
    }
}

public class RunningActivity : Activity
{
    private double elevationGain;

    public RunningActivity(DateTime startTime, DateTime endTime, double distance, double elevationGain) : base(startTime, endTime, distance)
    {
        this.elevationGain = elevationGain;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $", elevation gain: {elevationGain} m";
    }
}

public class CyclingActivity : Activity
{
    private double averagePower;

    public CyclingActivity(DateTime startTime, DateTime endTime, double distance, double averagePower) : base(startTime, endTime, distance)
    {
        this.averagePower = averagePower;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $", average power: {averagePower} watts";
    }
}

public class SwimmingActivity : Activity
{
    private double poolLength;

    public SwimmingActivity(DateTime startTime, DateTime endTime, double distance, double poolLength) : base(startTime, endTime, distance)
    {
        this.poolLength = poolLength;
    }

    public override double GetDistance()
    {
        return base.GetDistance() / poolLength;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $", pool length: {poolLength} m";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2022, 1, 1, 8, 0, 0), new DateTime(2022, 1, 1, 9, 0, 0), 10, 100),
            new CyclingActivity(new DateTime(2022, 1, 2, 8, 0, 0), new DateTime(2022, 1, 2, 10, 0, 0), 50, 200),
            new SwimmingActivity(new DateTime(2022, 1, 3, 8, 0, 0), new DateTime(2022, 1, 3, 9, 0, 0), 1.5, 25)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
// Tafadzwa Chingore