class SimpleGoal : Goal
{
    // Constructor for creation.
    public SimpleGoal()
    {

    }

    // Constructor for Loading.
    public SimpleGoal(string goalName, string goalDescription, int goalPoints, bool isCompleted) : base (goalName, goalDescription,goalPoints, isCompleted)
    {

    }

    // For saving SimpleGoal information.
    public override string ToString()
    {
        string goalString = $"{GetType()}~{GoalName}~{GoalDescription}~{GoalPoints}~{IsCompleted}";
        return goalString;
    }

    // Completes goal.
    public override int RecordEvent()
    {
        
        // User cannont recieve points for a completed goal.
        if (IsCompleted == false)
        {
            IsCompleted = true;
            return GoalPoints;
        }
        else
        {
            return 0;
        }
    }
}