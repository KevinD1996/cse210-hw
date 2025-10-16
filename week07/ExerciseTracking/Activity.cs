using System;

public abstract class Activity
{
    // Private member variables and encapsulation
    private string _date;
    private int _minutes;

    // Constructor
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Public getters
    public string GetDate() => _date;
    public int GetMinutes() => _minutes;

    // Abstract methods that can be overridden in derived classes
    public abstract double GetDistance(); // miles or km
    public abstract double GetSpeed();    // mph or kph
    public abstract double GetPace();     // minutes per mile or km

    // The common method for all activities
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():F2} miles, " +
               $"Speed {GetSpeed():F2} mph, " +
               $"Pace: {GetPace():F2} min per mile";
    }
}