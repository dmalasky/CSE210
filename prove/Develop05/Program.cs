using System;



// CREATIVITY 
// - Goals do not show up in the record list after they are completed.
// - Your goals are displayed after recording one.
// - Added a tally to EternalGoal


class Program
{
    static void Main(string[] args)
    {
        GoalHandling goalHandling = new GoalHandling();
        
        string choice = "";
        do
        {           
            // Displays points
            Console.WriteLine($"\nYou have {goalHandling.OverallPoints} points.\n");
            
            // Displays the menu.
            Console.WriteLine("Menu options");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            // Handles user choice.
            switch (choice)
            {
                // Create new goal
                case "1":
                    string GoalTypeChoice = "";
                    do
                    {
                        Console.WriteLine("The types of goals are: ");
                        Console.WriteLine("\t1. Simple Goal");
                        Console.WriteLine("\t2. Eternal Goal");
                        Console.WriteLine("\t3. Checklist Goal");
                        Console.WriteLine("\t4. Cancel");
                        Console.Write("What type of goal would you like to create: ");
                        GoalTypeChoice = Console.ReadLine();

                        // Allows user to choose a goal type.
                        switch (GoalTypeChoice)
                        {
                            // Create a Simple Goal.
                            case "1":
                                SimpleGoal simpleGoal = new SimpleGoal();
                                simpleGoal.CreateGoal();
                                goalHandling.SetGoalList(simpleGoal);
                            
                            
                                GoalTypeChoice = "4";
                                break;

                            // Create an Eternal Goal.
                            case "2":
                                EternalGoal eternalGoal = new EternalGoal();
                                eternalGoal.CreateGoal();
                                goalHandling.SetGoalList(eternalGoal);
                                GoalTypeChoice = "4";
                                break;

                            // Create a CheckList Goal.
                            case "3":
                                CheckListGoal checkListGoal = new CheckListGoal();
                                checkListGoal.CreateGoal();
                                goalHandling.SetGoalList(checkListGoal);
                                GoalTypeChoice = "4";
                                break;

                            // Cancel
                            case "4":
                                break;

                            // Error Handling
                            default:
                                Console.WriteLine("Invalid input, try again.");
                            break;

                        }
                    } while (GoalTypeChoice != "4");
                    
                    break;

                // List Goals
                case "2":
                    goalHandling.ListGoals();  

                    break;

                // Save Goals
                case "3":
                    goalHandling.SaveGoals();

                    break;

                // Load Goals
                case "4":
                    goalHandling.LoadGoals();
                    
                    break;

                // Record Event
                case "5":
                    goalHandling.RecordGoalEvent();

                    break;

                // Quit
                case "6":
                    break; 

                // Error handling.
                default:
                    Console.WriteLine("Invalid input, try again.");
                    choice = "0";
                    break;
            }
        } while (choice != "6") ;   
    }
}