using System;

// CREATIVITY - I made it so the duration must be in intervals of 10 so that the
// activities can have more consistency and gave the Breathing Activity a new animation.

class Program
{
    static void Main(string[] args)
    {
        
        string choice = "";
        

        while (choice != "4")
        {
            
            // Displays the menu.
            Console.WriteLine("Menu options");
            Console.WriteLine("\t1. Start Breathing Activity");
            Console.WriteLine("\t2. Start Reflecting Activity");
            Console.WriteLine("\t3. Start Listing Activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            string Description = "";

            // Handles user choice.
            switch (choice)
            {
                // Runs Breathing Activity.
                case "1":
                    Console.Clear();
                    Description = "This activity will help you relax by walking throught breathing " +
                                    "in an out slowly. Clear your mind and focus on your breathing.";
                    BreathingActivity b = new BreathingActivity("Breathing", Description);
                    b.StartingMessage();
                    b.SetDuration();
                    b.DeepBreathing();
                    b.EndingMessage();
                    Console.Clear();

                    break;
                // Runs Reflection Activity.
                case "2":
                    Console.Clear();
                    Description = "This activity will help you relfect on times in your life when you have shown " +
                                    "strength and resilience. This will help you recognize the power you have " + 
                                    "and how you can use it in other aspects of your life.";
                    ReflectionActivity r = new ReflectionActivity("Reflection", Description);
                    r.StartingMessage();
                    r.SetDuration();
                    Console.Clear(); 
                    r.Reflection();
                    r.EndingMessage();
                    Console.Clear();
                    
                    break;
                // Runs Listing Activity.
                case "3":
                    Console.Clear();
                    Description = "This activity will help you reflect on the good things in your life by having " +
                                    "you list as many things as you can in a certain area.";               
                    ListingActvity l = new ListingActvity("Listing", Description);
                    l.StartingMessage();
                    l.SetDuration();
                    Console.Clear(); 
                    l.Listing();
                    l.EndingMessage();
                    Console.Clear();
                    
                    break;
                // Ends program
                case "4":
                    return;
                // Error handling.
                default:
                    Console.WriteLine("Invalid input, try again.");
                    break;
            }
            
        }


    }
}