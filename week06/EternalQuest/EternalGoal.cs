class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) {}

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[∞] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}








// public class EternalGoal : Goal
// {
//     private int _timesRecorded;

//     public EternalGoal(string name, string description, int points) : base(name, description, points)
//     {
//         _timesRecorded = 0;
//     }

//     public override void RecordEvent()
//     {
//         _timesRecorded++;
//         Console.WriteLine($"You recorded an event for '{Name}' and gained {Points} points. Total records: {_timesRecorded}");
//     }

//     public override string GetStatus()
//     {
//         return base.GetStatus() + $" (Recorded {_timesRecorded} times)";
//     }
// }

















