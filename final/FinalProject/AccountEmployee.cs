public class AccountEmployee : Account
{
    // public Employee EmployeeType { get; private set; }
    // EmployeeHourly employeeHourly = new EmployeeHourly();

    public AccountEmployee()
    {

    }
    public AccountEmployee(string username, string password, bool isManager) : base (username, password, isManager)
    {
        
    }

    public override void ShowMenu()
    {
        Console.WriteLine("Pick one of the following");
        Console.WriteLine("\t1. Input hours/Jobs");
        Console.WriteLine("\t2. View current hours/jobs");
        Console.WriteLine("\t3. CalculatePay");
        Console.Write("Choose an option: ");
        // EmployeeType = employeeHourly;
        // Console.WriteLine(EmployeeType);
    }

}