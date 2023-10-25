using System.Diagnostics;
using System.Dynamic;

public class Scripture
{
    Reference reference = new Reference("Proverbs", "3", "5", "6");
    List<Word> words = new List<Word>();

    public Scripture(Reference scriptureReference, List<Word> wordList)
    {
        reference = scriptureReference;
        words = wordList;
    }

    // Displays the scripture
    public void DisplayScripture(List<Word> wordList)
    {
        
        reference.DisplayReference();
        foreach (Word word in wordList)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }

    // Hides random words.
    public void HideRandom(List<Word> wordList)
    {
        // Initialize needed variables
        Random random = new Random();
        int listLength = wordList.Count;
        bool hidden = false;
        int count = 0;


        while (hidden == false)
        {
            while (count < 3)
            {
                // Make sure there are stil lvisable words to hide
                if(IsAllHidden(wordList))
                {
                    return;
                }

                // Generate random number
                int randomNum = random.Next(0, listLength);

                // Finds text/hidden of random word
                hidden = wordList[randomNum].GetHidden();
                string text = wordList[randomNum].GetText();

                // If the word is not hidden, hide it.
                if (hidden == false)
                {
                    wordList[randomNum].SetHidden(true);
                    wordList[randomNum].SetText("_____");
                    hidden = true;
                    count++;
                                    
                }
            }   
        }
    }

    public bool IsAllHidden(List<Word> wordList)
    {
        
        bool hidden = true;

        foreach (Word word in wordList)
        {
            hidden = word.GetHidden();
            if (hidden == false)
            {
                return false;
            }
           
        }

        return true;
    }
    


}