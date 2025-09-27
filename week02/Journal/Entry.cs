using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mental;
    public string _time; 

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_mental}");
            
    }
}