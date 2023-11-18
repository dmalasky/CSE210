public abstract class Goal
{
    public string GoalName { get; private set; }
    public string GoalDescription { get; private set; }
    public int GoalPoints { get; private set; }
    public bool IsCompleted {get; protected set; }
    public string GoalListEntry { get; private set; }

    // Abstract methods
    public abstract int RecordEvent();
    
    public Goal()
    {
        
    }

    public Goal(string goalName, string goalDescription, int goalPoints, bool isCompleted)
    {
        GoalName = goalName;
        GoalDescription = goalDescription;
        GoalPoints = goalPoints;
        IsCompleted = isCompleted;
    }

    // For Eternal Goals
    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        GoalName = goalName;
        GoalDescription = goalDescription;
        GoalPoints = goalPoints;
    }
    
    // Base Goal Creation
    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        GoalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        GoalDescription = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        GoalPoints = int.Parse(Console.ReadLine());
        IsCompleted = false;
    }
    
    // formats a base GoalList entry for ListGoal()
    public virtual string GetGoalListEntry()
    {
        return $"{GoalName} ({GoalDescription})";
    }
    

  

     

    
   

    



}