using System;
using System.Collections.Concurrent;
using System.Text.Encodings.Web;

/*
            TODO:
            
            fix the way it looks.
        */

class Program
{
    static void Main(string[] args)
    {
        // create Reference object
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        
        // Create word object
        Word word = new Word();

        // List of type Word
        List<Word> words = new List<Word>();

        // text to pull from
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        
        // Parses text into a list of type Word.
        words = word.ParseText(text);
        
        // Create scripture object
        Scripture scripture = new Scripture(reference, words);
        
        // Displays the reference and text.
        

        // Loops the output.
        bool done = false;
        while (done != true)
        {
            Console.Clear();
            
            
            scripture.DisplayScripture(words);
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            
            string choice = Console.ReadLine().ToLower();
            
            if (choice == "quit")
            {
                return;
            }
            
            done = scripture.IsAllHidden(words);
            scripture.HideRandom(words);

            
            // If all words are hidden, end.
            
           

            
            
        }

    }
}









