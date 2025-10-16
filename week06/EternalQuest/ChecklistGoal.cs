class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}






// public class ChecklistGoal : Goal
// {
//     public int TargetCount { get; private set; }
//     public int CurrentCount { get; private set; }
//     public int BonusPoints { get; private set; }

//     public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
//     {
//         TargetCount = targetCount;
//         CurrentCount = 0;
//         BonusPoints = bonusPoints;
//     }

//     public override void RecordEvent()
//     {
//         if (CurrentCount < TargetCount)
//         {
//             CurrentCount++;
//             Console.WriteLine($"You recorded an event for '{Name}' and gained {Points} points. Progress: {CurrentCount}/{TargetCount}");
//             if (CurrentCount == TargetCount)
//             {
//                 Console.WriteLine($"Congratulations! You completed '{Name}' and earned a bonus of {BonusPoints} points!");
//             }
//         }
//         else
//         {
//             Console.WriteLine($"'{Name}' is already complete.");
//         }
//     }

//     public override string GetStatus()
//     {
//         return base.GetStatus() + $" -- Currently completed: {CurrentCount}/{TargetCount}" + (CurrentCount == TargetCount ? " [Complete]" : "");
//     }
// }



