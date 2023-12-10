using System.Reflection.Emit;

public class EmployeeSalary : Employee
{
    public float Salary { get; private set; }

    public EmployeeSalary()
    {
        
    }

    public EmployeeSalary(float salary)
    {
        Salary = salary;
    }

    public EmployeeSalary(string fName, string lName, string phone, string email, int employeeID,float salary) : base(fName, lName, phone, email, employeeID)
    {
        Salary = salary;
    }

    // Calculates pay for a Salary worker
    public override float CalculatePay()
    {
        return Salary * HoursInWorkWeek;
    }

    // Formatting for saving data.
    public override string SaveEmployeeFormat()
    {
        return $"{base.SaveEmployeeFormat()}~{Salary}";
    }
}