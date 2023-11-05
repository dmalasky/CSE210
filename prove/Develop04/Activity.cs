public class Activity
{
    public string ActivityName { get; private set; }
    public string ActivityDescription { get; private set; }
    public int Duration { get; private set; }
    public int RandomNum { get; private set; }
    

    public Activity()
    {
        
    }
    public Activity(string activityName, string activityDescription)
    {
        ActivityName = activityName;
        ActivityDescription = activityDescription;
        
    }

    // Displays an ending message for all activities.
    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {ActivityName} Activity \n\n{ActivityDescription}\n");
        
    }
    
    // Asks the user how the long they want to do the activity.
    public void SetDuration()
    {
        
        while (true)
        {
            Console.Write($"How long, in seconds (intervals of 10), would you like your session to be? ");
            string input = Console.ReadLine();
            int duration = int.Parse(input);
            if (duration % 10 == 0)
            {
                Duration = duration;
                return;
            }
            else 
            {
                Console.WriteLine("The duration must be an interval of 10");
            }
        }

    }
    
    // Displays an ending message for all activities.
    public void EndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Spinner();
        Console.WriteLine($"\nYou have completed another {Duration} seconds of the {ActivityName} Activity.");
        Spinner();
        
    }
    
    // Shows a spinner animation.
    public void Spinner()
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
        DateTime endTime = startTime.AddSeconds(5); // end time is a future time.

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
    
    // Displays a countdown for the user based on programmer input.
    public void ShowCountdown(int length)
    {
        // Countdown
        for (int i = length; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    // Shows a random prompt to the user.
    public void DisplayPrompt(List<string> Prompts)
    {
        int length = Prompts.Count;
        int RandomNum = RandomNumGen(length - 1); // Generates random number.
        Console.WriteLine($" --- {Prompts[RandomNum]} --- ");
        
    }
    
    // Generates a random number from 0 to programmer input.
    public int RandomNumGen(int NumRange)
    {
        Random random = new Random();

        // Generate a random integer between 1 and NumRange
        int RandomNum = random.Next(0, NumRange + 1);

        return RandomNum;
    }

   


}