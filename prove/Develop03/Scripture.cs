using System.Diagnostics;
using System.Dynamic;
// Keep track of the scripture as a whole (ref + words)
public class Scripture
{
    // // prop tab public with get set makes it private behind the scenes.
    // public string Text { get; set; }

    Reference reference = new Reference("Proverbs", "3", "5", "6");
    List<Word> words = new List<Word>();

    public Scripture(Reference scriptureReference, List<Word> wordList)
    {
        reference = scriptureReference;
        words = wordList;
    }

    public void DisplayScripture(List<Word> wordList)
    {
        
        reference.DisplayReference();
        foreach (Word word in wordList)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }

    public void HideWords(List<Word> wordList)
    {
        int count = 0;
        foreach (Word word in wordList)
        {
            
            if (word.GetHidden() == false)
            {
                word.SetHidden(true);
                word.SetText("_____");
                count++;
                if (count == 3)
                {
                    return;
                }
            }
        }
        
    }

    public int RandomIndex(List<Word> wordList)
    {
        Random random = new Random();

        int listLength = wordList.Count;

        int randomNum = 0;
        bool hidden = false;
        while (hidden != true)
        {  
            randomNum = random.Next(0, listLength);

            hidden = wordList[randomNum].GetHidden();
            string text = wordList[randomNum].GetText();
            Console.WriteLine($"{hidden} {text}");
        }
        return randomNum; // 1, randomNum2, randomNum3;

    }

    public void HideRandom()
    {
        int count = 0;
        while (count < 3);
            
    }
    
   
    // _text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledg him, and he shall direct thy paths.";
    


}