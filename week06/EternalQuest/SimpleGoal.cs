class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}






// public class SimpleGoal : Goal
// {
//     public bool IsComplete { get; private set; }

//     public SimpleGoal(string name, string description, int points) : base(name, description, points)
//     {
//         IsComplete = false;
//     }

//     public override void RecordEvent()
//     {
//         if (!IsComplete)
//         {
//             IsComplete = true;
//             Console.WriteLine($"Congratulations! You completed '{Name}' and gained {Points} points.");
//         }
//         else
//         {
//             Console.WriteLine($"'{Name}' is already complete.");
//         }
//     }

//     public override string GetStatus()
//     {
//         return base.GetStatus() + (IsComplete ? " [Complete]" : " [Incomplete]");
//     }
// }




