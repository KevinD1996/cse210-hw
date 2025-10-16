public class Program
{
    public static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectionActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu options for Mindfulness Program:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. View Activity Statistics");
            Console.WriteLine("5. Quit");
            Console.Write("Please select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathingActivity.StartActivity();
                    break;
                case "2":
                    reflectionActivity.StartActivity();
                    break;
                case "3":
                    listingActivity.StartActivity();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("--- Activity Statistics ---");
                    breathingActivity.DisplayStatistics();
                    reflectionActivity.DisplayStatistics();
                    listingActivity.DisplayStatistics();
                    Console.WriteLine("Press Enter to return to the main menu.");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("Quitting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1900);
                    break;
            }
        }
    }
}