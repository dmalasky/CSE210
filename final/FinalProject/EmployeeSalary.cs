using System.Reflection.Emit;

public class EmployeeSalary : Employee
{
    public float Salary { get; private set; }


    public EmployeeSalary()
    {
        
    }

    public EmployeeSalary(string fName, string lName, string phone, string email, int employeeID, Account account, float salary) : base(fName, lName, phone, email, employeeID, account)
    {
        Salary = salary;
    }

    public EmployeeSalary(string fName, string lName, string phone, string email, int employeeID, float salary) : base(fName, lName, phone, email, employeeID)
    {
        Salary = salary;
    }

    public override float CalculatePay()
    {
        throw new NotImplementedException();
    }

    public override string SaveEmployeeFormat()
    {
        return $"{base.SaveEmployeeFormat()}~{Salary}";
    }
}