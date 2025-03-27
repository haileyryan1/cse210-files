public class Activity
{
    private string _date;
    private int _duration; 

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }

    public int GetDuration() => _duration;
}
