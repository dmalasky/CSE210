using System;
using System.Globalization;
using System.Security.Cryptography;

public class PromptGenerator
{
    public List<string> Prompts = new List<string>();
    public int RandNum = 0;
    public PromptGenerator()
    {
        // Adding elements in the constructor
        Prompts.Add("Who was the most interesting person I interacted with today?");
        Prompts.Add("What was the best part of my day?");
        Prompts.Add("How did I see the hand of the Lord in my life today?");
        Prompts.Add("What was the strongest emotion I felt today?");
        Prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    
    public int RandNumGen()
    {
        Random random = new Random();

        RandNum = random.Next(0, 4 + 1);
        return RandNum;
    }
    public string RandPrompt()
    {
        RandNum = RandNumGen();
        string randomPrompt  = (Prompts[RandNum]);
        return randomPrompt;
    }

}