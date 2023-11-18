class CheckListGoal : Goal
{
    public int ReqReps { get; private set; }
    public int NumReps { get; private set; }
    public int BonusPoints { get; private set; }
    
    // Constructor for creation.
    public CheckListGoal()
    {

    }

    // Constructor for Loading.
    public CheckListGoal(string goalName, string goalDescription, int goalPoints, bool isCompleted,
        int numReps, int reqReps, int bonusPoints) : base (goalName, goalDescription, goalPoints, isCompleted)
    {
        NumReps = numReps;
        ReqReps = reqReps; 
        BonusPoints = bonusPoints;
    }

    // Adds reps and bonus points to the base creation.
    public override void CreateGoal()
    {
        // Do the first three prompts
        base.CreateGoal();
        // and then do two more.
        Console.Write("How many repetitions until completion? ");
        ReqReps = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points is the completion worth? ");
        BonusPoints = int.Parse(Console.ReadLine());
    }

    // Adds reps to the GoalList entry
    public override string GetGoalListEntry()
    {
        return $"{base.GetGoalListEntry()} -- Currently Completed: {NumReps}/{ReqReps}";
    }

    // For saving CheckListGoal information.
    public override string ToString()
    {
        string goalString = $"{GetType()}~{GoalName}~{GoalDescription}~{GoalPoints}~{IsCompleted}~{NumReps}~{ReqReps}~{BonusPoints}";
        return goalString;
    }

    // Records reps and completes goal when done.
    public override int RecordEvent()
    {
        // Add a completed rep if not done.
        if (NumReps < ReqReps)
        {
            NumReps++;
            
            // Complete goal after all reps are complete and give bonus points.
            if (NumReps == ReqReps)
            {
                IsCompleted = true;
                return GoalPoints + BonusPoints; // Points for final rep + completion.
            }

            return GoalPoints; // Points for 1 rep.
        }

        return 0; // No points if completed.
        
    }
}