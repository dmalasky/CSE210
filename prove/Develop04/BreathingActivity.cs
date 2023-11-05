class BreathingActivity : Activity
{


    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {

    }

    public void DeepBreathing() 
    {
        
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);
        
        
        while (DateTime.Now < endTime)
        {
            // Breath in
            Console.Write("\nBreathe in...");
            ShowCountdown(4);
         
            // Breath out
            Console.Write("\nBreathe out...");
            ShowCountdown(6);
            Console.WriteLine();
            
        }
        
        // print a certain amount of something
        // string spaces = new string(' ', 4);
        // Console.Write(spaces);
        
        
    }

    public void BreathingAnimation()
    {

        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }


    }
    
    
}