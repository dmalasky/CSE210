public class EmployeeHourly : Employee
{
    public float rate { get; private set; }
    public float hours { get; private set; }

    public EmployeeHourly()
    {
        
    }



    public override float CalculatePay()
    {
        throw new NotImplementedException();
    }
}