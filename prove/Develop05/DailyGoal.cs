class DailyGoal : Goal
{
    public bool HasDayPassed { get; private set; }
    public DailyGoal()
    {

    }

    public DailyGoal(string goalName, string goalDescription, int goalPoints, bool isCompleted, bool hasDayPassed) : base (goalName, goalDescription,goalPoints, isCompleted)
    {
        HasDayPassed = hasDayPassed;
    }


    public void CheckTime()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5); // end time is a future time.

        if (endTime <= startTime)
        {
            IsCompleted = false;
        }
        
        
    }

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
