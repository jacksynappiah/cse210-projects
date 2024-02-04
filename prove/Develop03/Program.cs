using System;
using System.Collections.Generic;

// The main program class
class Program
{
    // The main method
    static void Main(string[] args)
    {
        // Create a scripture object with a reference and a text
        Scripture scripture = 
        new Scripture(
            new ScriptureMastery
        ("1 Nephi", 3, 7), 
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them."
        );

        // Clear the console screen and display the complete scripture[^2^][2]
        Console.Clear();
        Console.WriteLine(scripture);

        // Prompt the user to press the enter key or type quit
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
        string input = Console.ReadLine();

        // Repeat until the user types quit or all words are hidden
        while (input != "quit" && !scripture.IsAllHidden())
        {
            // Hide a few random words in the scripture
            scripture.HideWords();
            // Clear the console screen and display the scripture again[^2^][2]
            Console.Clear();
            Console.WriteLine(scripture);
            // Prompt the user again
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            input = Console.ReadLine();
        }

        // If all words are hidden, congratulate the user
        if (scripture.IsAllHidden())
        {
            Console.WriteLine("\nYou have memorized the scripture!");
        }
    }
}
