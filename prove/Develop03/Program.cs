using System;
using System.Collections.Concurrent;
using System.Text.Encodings.Web;

/*
            TODO:
            Hide random words start with 1
            Hide 3 random words
            If all words are hidden enter should close program
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
        scripture.DisplayScripture(words);

        // Loops the output.
        bool done = false;
        while (done != true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string choice = Console.ReadLine().ToLower();
            
            if (choice == "quit")
            {
                return;
            }
            
            scripture.HideWords(words);
            scripture.DisplayScripture(words);
            scripture.RandomIndex(words);

            // if all words == hidden done = true.

        }



    }
}









