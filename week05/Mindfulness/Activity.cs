using System;
using System.Threading;

// Base class for all mindfulness activities
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds
    protected DateTime _lastPerformed;
    protected int _performCount;
    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _lastPerformed = DateTime.MinValue; // Initialize to a default value
        _performCount = 0;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long, in second, would you like for your section?");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prepare to begin...");
        Thread.Sleep(7000); // Pause for 6 seconds

        PerformActivity();

        EndActivity();
    }

    protected abstract void PerformActivity();

    protected void EndActivity()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another  {_duration} seconds of the {_name}.");
        _lastPerformed = DateTime.Now;
        _performCount++;
        Console.WriteLine("Returning to main menu...");
        Thread.Sleep(7000);
    }

    public void DisplayStatistics()
    {
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"Last Performed: {(_lastPerformed == DateTime.MinValue ? "Never" : _lastPerformed.ToString())}");
        Console.WriteLine($"Times Performed: {_performCount}");
    }
}




//using System;

//public class Activity
//{
//    private string _name;
 //   private string _description;
//    private  int _duration;
//    {
//       Activity()
//       {
//       public void DisplayStartingMessage();
//       public void DisplayEndingMessage();
//       public void ShowSpinner(seconds int);
//       public void ShowCountDown(seconds int);
//       } 
//    }
//}