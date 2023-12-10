using System.Dynamic;

public abstract class Employee 
{
    public string FName { get; private set; }
    public string LName { get; private set; }
    public string Phone { get; private set; }
    public string Email { get; private set; }
    public int EmployeeID { get; private set; }

    protected int HoursInWorkWeek = 40; // The program currently calcs pay for a single week at a time.

    public abstract float CalculatePay();

    public Employee()
    {

    }

    public Employee(string fName, string lName, string phone, string email, int employeeID)
    {
        FName = fName;
        LName = lName;
        Phone = phone;
        Email = email;
        EmployeeID = employeeID;

    }
  
    // Formatting for saving data.
    public virtual string SaveEmployeeFormat()
    {
        return $"{EmployeeID}~{GetType()}~{FName}~{LName}~{Phone}~{Email}";
    }
   


}