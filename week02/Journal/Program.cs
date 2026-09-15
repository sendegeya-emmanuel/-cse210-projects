using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public string _moodText = "";

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_moodText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine("---------------------------------------------");
    }
}

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._moodText}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
            if (parts.Length == 4)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                entry._moodText = parts[3];
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}

class Program
{
    // CREATIVITY STATEMENT:
    // I exceeded the core requirements by implementing a custom "Mood Tracker" indicator for each entry.
    // The user inputs their emotional state (e.g., Joyful, Stressed, Calm) alongside the response.
    // This metadata is saved to the data file, parsed, and displayed in the structural output.

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        int userChoice = -1;

        Console.WriteLine("Welcome to the Journal Program!");

        while (userChoice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out userChoice))
            {
                if (userChoice == 1)
                {
                    int index = random.Next(prompts.Count);
                    string selectedPrompt = prompts[index];

                    Console.WriteLine($"\nPrompt: {selectedPrompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Console.Write("Enter your current mood: ");
                    string mood = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = selectedPrompt;
                    newEntry._entryText = response;
                    newEntry._moodText = mood;

                    journal.AddEntry(newEntry);
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("\n--- Displaying All Entries ---");
                    journal.DisplayAll();
                }
                else if (userChoice == 3)
                {
                    Console.Write("Enter the filename to load: ");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                }
                else if (userChoice == 4)
                {
                    Console.Write("Enter the filename to save: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                }
            }
        }
        Console.WriteLine("Goodbye!");
    }
}