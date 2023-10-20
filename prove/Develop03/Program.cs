using System;
using System.Collections.Concurrent;
using System.Text.Encodings.Web;

class Program
{
    static void Main(string[] args)
    {
        // create Reference object
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        Word word = new Word();

        // List<Word> asdf = new List<Word>(); Maybe a list of words for "hidden" and the "word"
        
        List<string> words = new List<string>();

        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        
        words = word.ParseText(text);
        /*
            TODO:
            Make the display function work
            figure out how the word constructor should work
            Make sure the methods in Word are working effiecinetly (parameters) so it can handle different scriptures.
        */

        // Displays the scripture and reference.
        reference.DisplayReference();
        word.DisplayText(words);

        bool done = false;
        while (done != true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string choice = Console.ReadLine().ToLower();
            
            if (choice == "quit")
            {
                return;
            }

            Console.WriteLine("Try again");


        }



    }
}









