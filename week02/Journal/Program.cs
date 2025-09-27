using System;
using System.Collections.Generic;
using System.IO;

public class JournalProgram
{
    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

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

        Console.WriteLine("\nYour entry has been recorded:");
        Console.WriteLine(fullEntry);

        
    }

    private static void DisplayEntries()
    {
        Console.WriteLine("\nDisplaying all entries.");
        Console.WriteLine("To see saved entries, load from a file after saving.");
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

        else
        {
            
            string filename = $"Date/Time: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\nPrompt: {entryContent}\nEntry: {entryContent}\n";
            File.AppendAllText(filename, entryContent);
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
                string content = File.ReadAllText(filename);
                Console.WriteLine($"\nJournal loaded from {filename}:\n");
                Console.WriteLine(content);
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