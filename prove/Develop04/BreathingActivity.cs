class BreathingActivity : Activity
{

    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {

    }

    // Breathing Actvity.
    public void DeepBreathing() 
    {
        
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner();
        
        // Determines how the long the activity is.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);
        
        
        // Loop until time runs out
        while (DateTime.Now < endTime)
        {
            // Breath in
            Console.WriteLine("\nBreathe in...");
            BreatheIn(4);
         
            // Breath out
            Console.WriteLine("\nBreathe out...");
            BreatheOut(6);
            Console.WriteLine();
            
        }
  
    }

    // Breathe in animation.
    public void BreatheIn(int length)
    {
        
        Console.Write("<");
        for (int i = length; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(1000);
        }   
        
    }

    // Breate out animation.
    public void BreatheOut(int length)
    {
        
        int cursorLeft = Console.CursorLeft; // Keep track of starting postion.

        for (int i = 1; i <= length; i++)
        {
            string dashes = new string('-', i);
            Console.SetCursorPosition(cursorLeft, Console.CursorTop); // Set cursor position
            Console.Write(dashes + ">");
            

            Thread.Sleep(1000);
        }
       
    }
    
}