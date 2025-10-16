// Derived class for Reflecting Activity
public class ReflectingActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you demonstrated true strength."
    };

    private string[] _questions = {
        "How did you feel when it was over?",
        "What did you learn about yourself through this experience?",
        "How can you apply this experience to other areas of your life?",
        "What made this experience meaningful to you?"
    };

    public ReflectingActivity() : base("Reflecting Activity:", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        int elapsedSeconds = 0;

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"{_prompts[rand.Next(_prompts.Length)]}");
        Console.WriteLine("When you have thought about it, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now, ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in a few seconds...");
        Thread.Sleep(5000);

        while (elapsedSeconds < _duration)
        {
            string question = _questions[rand.Next(_questions.Length)];
            Console.WriteLine($"> {question}");
            Thread.Sleep(8000); // Provide time to reflect on the question
            elapsedSeconds += 8;
        }
    }
}




// using System;

// public class ReflectingActivity: Activity
// {
    // private List<string> _prompts;
    // private List<string> _questions;
    // {
        // ReflectingActivity()
        // {
            // public void Run();
            // public string GetRandomPrompt();
            // public string GetRandomQuestion();
            // public void DisplayPrompt();
            // public void DisplayQuestions()
        // }
    // }
// }