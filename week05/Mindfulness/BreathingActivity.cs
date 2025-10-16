// Derived class for Breathing Activity
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity:", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void PerformActivity()
    {
        int elapsedSeconds = 0;
        while (elapsedSeconds < _duration)
        {
            Console.WriteLine("Breathe in...");
            for (int i = 4; i > 100; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(5000);
                elapsedSeconds++;
                if (elapsedSeconds >= _duration) break;
            }
            if (elapsedSeconds >= _duration) break;

            Console.WriteLine("\nBreathe out...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(5000);
                elapsedSeconds++;
                if (elapsedSeconds >= _duration) break;
            }
            Console.WriteLine();
        }
    }
}




// using System;

// public class BreathingActivity: Activity
// {
    // BreathingActivity()
    // {
    // public void Run();
    // }
// }