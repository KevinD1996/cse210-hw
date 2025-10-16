// Derived class for Listing Activity
public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "What are some of your favorite things?",
        "What are things you are grateful for?"
    };

    public ListingActivity() : base("Listing Activity:", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        int elapsedSeconds = 0;
        int itemCount = 0;

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"{_prompts[rand.Next(_prompts.Length)]}");
        Console.WriteLine("You may begin in a few seconds...");
        Thread.Sleep(4000);

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Enter an item (or press Enter to finish if time is up): ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
            elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
        }
        Console.WriteLine($"You listed {itemCount} items.");
    }
}


// using System;

// public class ListingActivity: Activity
// {
    // private int _count;
    // private List<string> _prompts;
    // {
        // ListingActivity()
        // {
            // public void Run();
            // public string GetRandomPrompt();
            // public List<string> GetListFromUser();
        // }
    // }
// }