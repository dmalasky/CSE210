using System.IO;

public class GoalHandling 
{
    public int OverallPoints { get; protected set; } = 0;
    List<Goal> GoalList = new List<Goal>();
    
    // Constructor
    public GoalHandling()
    {

    }

    // Populates the list of Goals
    public void SetGoalList(Goal goalToBeAdded)
    {
        GoalList.Add(goalToBeAdded);
    }

    // Lists goals for option 2.
    public void ListGoals()
    {
        int count = 1;
        foreach (Goal goal in GoalList)
        { 
            // Determine when to check goals off
            if (goal.IsCompleted == false)
            {
                Console.WriteLine($"{count}. [ ] {goal.GetGoalListEntry()}");
            }
            else
            {
                Console.WriteLine($"{count}. [X] {goal.GetGoalListEntry()}");
            }
            
            count += 1;
        }
    }

    // Save goal information to a file for option 3.
     public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(OverallPoints);
            foreach (Goal goal in GoalList)
            {  
                outputFile.WriteLine(goal.ToString());
            }
        }
    }

    // Loads goals from a txt file
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        
        string[] lines = File.ReadAllLines(fileName);
        
        // Iterates through the file, constructs goals, and adds them to GoalList.
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                GoalList.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {  
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                GoalList.Add(eternalGoal);
            }
            else if (parts[0] == "CheckListGoal")
            {
                CheckListGoal checkListGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]),
                    int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                GoalList.Add(checkListGoal);
            }
            else
            {
                OverallPoints = int.Parse(parts[0]);
            }
        }  
    }

    // Records a singular event for option 5.
    public void RecordGoalEvent()
    {
        
        int count = 1;
        foreach (Goal goal in GoalList)
        {  
            // Only shows uncompleted goals
            if (goal.IsCompleted == false)
            {    
                Console.WriteLine($"{count}. {goal.GoalName}");
                
            }
            count++;
        }
        
        Console.Write("Which goal would you like to record? "); // do this after you list the goals
        int choice = int.Parse(Console.ReadLine());
        
        // Goal currently being changed.
        Goal CurrentGoal = GoalList[choice - 1];

        // Records event and points earned.
        int PointsEarned = CurrentGoal.RecordEvent(); // calls the abstract function 'RecordEvent()'
        Console.WriteLine($"\nCongratulations you have earned {PointsEarned} points!");

        // Totals points
        OverallPoints += PointsEarned;

        // Show goals.
        Console.WriteLine();
        ListGoals();
    }

    


}