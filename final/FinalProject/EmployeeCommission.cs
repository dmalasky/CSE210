public class EmployeeCommission : Employee
{
    Dictionary<string, int> Jobs = new Dictionary<string, int>();


    public EmployeeCommission()
    {

    }

    public override float CalculatePay()
    {
        throw new NotImplementedException();
    }
}