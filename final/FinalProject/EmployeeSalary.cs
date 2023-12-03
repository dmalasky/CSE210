using System.Reflection.Emit;

public class EmployeeSalary : Employee
{
    public float Salary { get; private set; }


    public EmployeeSalary()
    {
        
    }


    public override float CalculatePay()
    {
        throw new NotImplementedException();
    }
}