using System;
// Importing necessary libraries
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Class to store each journal entry
public class Entry
{
    // The question asked
    public string Prompt { get; set; }
    // The answer given
    public string Response { get; set; }
    // The date of the entry
    public DateTime Date { get; set; }
}

// Class to manage the journal
public class Journal
{
    // List to store all entries
    private List<Entry> entries = new List<Entry>();
    // List of questions
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // Method to write a new entry
    public void WriteEntry()
    {
        // Create a random object
        var random = new Random();
        // Select a random question
        var prompt = prompts[random.Next(prompts.Count)];

        // Display the question
        Console.WriteLine(prompt);
        // Get the answer
        var response = Console.ReadLine();

        // Add the new entry to the list
        entries.Add(new Entry { Prompt = prompt, Response = response, Date = DateTime.Now });
    }

    // Method to display all entries
    public void DisplayJournal()
    {
        // For each entry in the list
        foreach (var entry in entries)
        {
            // Display the entry
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
        }
    }

    // Method to save the journal to a file
    public void SaveJournal()
    {
        // Ask for the filename
        Console.WriteLine("Enter filename:");
        // Get the filename
        var filename = Console.ReadLine();

        // Create a new file with the given filename
        using (var writer = new StreamWriter(filename))
        {
            // For each entry in the list
            foreach (var entry in entries)
            {
                // Write the entry to the file
                writer.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
            }
        }
    }

    // Method to load the journal from a file
    public void LoadJournal()
    {
        // Ask for the filename
        Console.WriteLine("Enter filename:");
        // Get the filename
        var filename = Console.ReadLine();

        // Clear the current list of entries
        entries.Clear();

        // Open the file with the given filename
        using (var reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Split the line into parts
                var parts = line.Split(new[] { ", Prompt: ", ", Response: " }, StringSplitOptions.None);
                // Get the date
                var date = DateTime.Parse(parts[0].Substring(6));
                // Get the question
                var prompt = parts[1];
                // Get the answer
                var response = parts[2];

                // Add the entry to the list
                entries.Add(new Entry { Date = date, Prompt = prompt, Response = response });
            }
        }
    }

    // Method to run the journal application
    public void Run()
    {
        // Infinite loop
        while (true)
        {
            // Display the menu
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            // Get the user's choice
            var option = Console.ReadLine();

            // Depending on the user's choice
            switch (option)
            {
                // Write a new entry
                case "1":
                    WriteEntry();
                    break;
                // Display the journal
                case "2":
                    DisplayJournal();
                    break;
                // Save the journal to a file
                case "3":
                    SaveJournal();
                    break;
                // Load the journal from a file
                case "4":
                    LoadJournal();
                    break;
                // Exit the application
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}

