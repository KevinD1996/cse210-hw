using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
         _entries.Add(newEntry);

    }
    
    public void DisplayAll()   
    {
    foreach (Entry entry in _entries)
    
    {
        entry.Display();
    }
    }
    public void SaveFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputfile.WriteLine($"{entry._date}|{entry._time}|{entry._promptText}|{entry._entryText}|{entry._mental}");

            }

        }

    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._time = parts[1];
            entry._promptText = parts[2];
            entry._entryText = parts[3];
            entry._mental = parts[4];
            entry.Add(entry);


        }

    }
       

}



