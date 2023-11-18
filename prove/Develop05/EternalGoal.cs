class EternalGoal : Goal
{
    // maybe make it so if its completed today its checks, then 24 hours later reset it.
    public int Tally { get; private set; }
    
    // Constructor for creation.
    public EternalGoal()
    {

    }
    
    // Constructor for Loading.
    public EternalGoal(string goalName, string goalDescription, int goalPoints, int tally) : base (goalName, goalDescription,goalPoints)
    {
        Tally = tally;
    }

    // Adds a tally to the GoalList entry
    public override string GetGoalListEntry()
    {
        return $"{base.GetGoalListEntry()} -- Completed {Tally} times";
    }

    // For saving EternalGoal information.
    public override string ToString()
    {
        string goalString = $"{GetType()}~{GoalName}~{GoalDescription}~{GoalPoints}~{Tally}";
        return goalString;
    }
    
    // Records amount of times completed.
    public override int RecordEvent()
    {
        Tally++;
        return GoalPoints;
    }
}