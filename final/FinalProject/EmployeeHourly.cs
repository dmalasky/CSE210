public class EmployeeHourly : Employee
{
    // TODO
    // Maybe add HoursScheduled vs HoursWorked
    
    public float Rate { get; private set; }
    public float Hours { get; private set; }

    public EmployeeHourly()
    {
        
    }
    public EmployeeHourly(string fName, string lName, string phone, string email, int employeeID, Account account, float rate, float hours) : base(fName, lName, phone, email, employeeID, account)
    {
        Rate = rate;
        Hours = hours;
    }


    public override float CalculatePay()
    {
        throw new NotImplementedException();
    }

    public override string SaveEmployeeFormat()
    {
        return $"{base.SaveEmployeeFormat()}~{Rate}~{Hours}";
    }
}