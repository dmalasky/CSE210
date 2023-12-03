public abstract class Employee 
{
    public string name { get; private set; }
    public string phone { get; private set; }
    public string email { get; private set; }
    public string EmployeeID { get; private set; }


    public abstract float CalculatePay();

}