using System;
using System.Collections.Generic;
using System.IO;

public class JournalProgram
{
    private static List<string> prompts = new List<string>
    {
        "What challenge did you overcome today?",
        "What are you grateful for right now?",
        "Describe a moment of peace you experienced today.",
        "What is one thing you learned today?",
        "If you could change one thing about today, what would it be?",
        "What is a goal you have for tomorrow?",
        "What emotions did you feel today and why?",
        "Describe a conversation that impacted you today.",
        "What is a small act of kindness you witnessed or performed today?"
    };

    
    private static List<string> entries = new List<string>();

    public static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    Console.WriteLine("Quitting journal program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following options:\n");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("Please enter your choice: ");
    }

    private static void WriteNewEntry()
    {
        Random rand = new Random();
        string randomPrompt = prompts[rand.Next(prompts.Count)];

        Console.WriteLine($"\nPrompt: {randomPrompt}");
        Console.Write("Your entry: ");
        string entryContent = Console.ReadLine();

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string fullEntry = $"Date/Time: {timestamp}\nPrompt: {randomPrompt}\nEntry: {entryContent}\n";

       
        entries.Add(fullEntry);

        Console.WriteLine("\nYour entry has been recorded:");
        Console.WriteLine(fullEntry);
    }

    private static void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nNo entries recorded yet.");
        }
        else
        {
            Console.WriteLine("\nDisplaying all journal entries:\n");
            foreach (string entry in entries)
            {
                Console.WriteLine(entry);
                Console.WriteLine("------------------------------");
            }
        }
    }

    private static void SaveJournalToFile()
    {
        Console.Write("Enter filename to save (e.g. myjournal.txt): ");
        string filename = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("Filename cannot be empty.");
            return;
        }

        try
        {
            File.WriteAllLines(filename, entries);
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    private static void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load (e.g. myjournal.txt): ");
        string filename = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("Filename cannot be empty.");
            return;
        }

        try
        {
            if (File.Exists(filename))
            {
                string[] loadedEntries = File.ReadAllLines(filename);
                entries.Clear();
                entries.AddRange(loadedEntries);

                Console.WriteLine($"\nJournal loaded from {filename}:\n");
                foreach (string entry in entries)
                {
                    Console.WriteLine(entry);
                    Console.WriteLine("------------------------------");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
