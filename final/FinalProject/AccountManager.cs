public class AccountManager : Account
{
    
    public AccountManager()
    {
        
    }

    public AccountManager(string username, string password, bool isManager) : base (username, password, isManager)
    {
        
    }




    public override void ShowMenu()
    {
        Console.WriteLine("Pick one of the following");
        Console.WriteLine("\t1. Input hours/Jobs for an employee");
        Console.WriteLine("\t2. Add Employee");
        Console.WriteLine("\t3. Remove Employee");
        Console.WriteLine("\t4. List Employees");
        Console.WriteLine("\t5. Edit Employee information");
        Console.WriteLine("\t6. Calculate pay for one employee");
        Console.WriteLine("\t7. Calculate pay for all"); // list all employees and pay, maybe with total
        Console.Write("Choose an option: ");
    }
}