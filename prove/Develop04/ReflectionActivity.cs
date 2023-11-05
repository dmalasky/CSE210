class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    
    public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
        
    }

    // TODO
    // Make it work with Duration
    // Display more than one question. maybe 10 seconds per question.

    public void Reflection() 
    {
        
        Console.WriteLine("Get Ready...");
        Spinner();

        Console.WriteLine("\nConsider the following Prompt: ");
        DisplayPrompt(_reflectionPrompts);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in ");
        ShowCountdown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);
        
        
        while (DateTime.Now < endTime)
        {
            DisplayQuestions(_reflectionQuestions);
            LongSpinner();
            Console.WriteLine();
        }    
        
        
        
    }

    public void DisplayQuestions(List<string> Prompts)
    {
        int length = Prompts.Count;
        int RandomNum = RandomNumGen(length - 1);
        Console.Write($"> {Prompts[RandomNum]} ");
    }

    public void LongSpinner()
    {
        
        // Makes a list for the spinner animation
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        
        // Controls how long the spinner goes.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10); // end time is a future time.

        // Loops for however many seconds and shows animation.
        int i = 0;
        while (DateTime.Now < endTime)
        {
            
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(700);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count - 1)
            {
                i = 0;
            }
        }


    }
}