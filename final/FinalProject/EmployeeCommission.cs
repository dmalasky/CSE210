public class EmployeeCommission : Employee
{
    Dictionary<string, int> Jobs = new Dictionary<string, int>();


    public EmployeeCommission()
    {

    }

    public EmployeeCommission(string fName, string lName, string phone, string email, int employeeID, Account account) : base(fName, lName, phone, email, employeeID, account)
    {

    }

    public override float CalculatePay()
    {
        throw new NotImplementedException();
    }
}