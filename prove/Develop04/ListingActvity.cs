class ListingActvity : Activity
{
    public ListingActvity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {

    }
    
    // Stores prompts for the user.
    private List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Listing Activity. 
    public void Listing()
    {
        Console.WriteLine("Get Ready...");
        Spinner();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        DisplayPrompt(_listingPrompts);
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);
        CollectEntries();

    }

    // Displays the Entries to the user and saves how many items they list.
    public void CollectEntries()
    {
        List<string> Entries = new List<string>();

        // Determines how the long the activity is.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration); 
        
        // Loop until the time runs out.
        while (DateTime.Now < endTime)
        {
            
            Console.Write("> ");
            Entries.Add(Console.ReadLine());
           
        }

        // Show the item count.
        int EntryNum = Entries.Count;
        Console.WriteLine($"You listed {EntryNum} items");
        

    }
    
}
