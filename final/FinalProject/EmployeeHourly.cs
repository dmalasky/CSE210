public class EmployeeHourly : Employee
{
    
    public float Rate { get; private set; }
    public float HoursScheduled { get; private set; }
    public float HoursWorked {get; private set;}

    public EmployeeHourly()
    {
        
    }

    public EmployeeHourly(float rate, float hoursWorked)
    {
        Rate = rate;
        HoursWorked = hoursWorked;
    }

    public EmployeeHourly(string fName, string lName, string phone, string email, int employeeID, float rate, float hoursScheduled) : base(fName, lName, phone, email, employeeID)
    {
        Rate = rate;
        HoursScheduled = hoursScheduled;
    }

    // Calculates pay for an hourly worker.
    public override float CalculatePay()
    {
        return HoursWorked * Rate;
    }

    // Formatting for saving data.
    public override string SaveEmployeeFormat()
    {
        return $"{base.SaveEmployeeFormat()}~{Rate}~{HoursWorked}~{HoursScheduled}";
    }

    // Set HoursWorked for pay calcs.
    public float SetHoursWorked(float hoursToAdd)
    {
        HoursWorked = HoursWorked + hoursToAdd;
        return HoursWorked;
    }
}