abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}






// // Base class for all goals
// public abstract class Goal
// {
//     public string Name { get; protected set; }
//     public string Description { get; protected set; }
//     public int Points { get; protected set; }

//     public Goal(string name, string description, int points)
//     {
//         Name = name;
//         Description = description;
//         Points = points;
//     }

//     // Abstract method to be implemented by derived classes
//     public abstract void RecordEvent();

//     // Virtual method for displaying goal status, can be overridden
//     public virtual string GetStatus()
//     {
//         return $"{Name} ({Description}) - {Points} points";
//     }
// }

