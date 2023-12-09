using System.Dynamic;

public abstract class Employee 
{
    public string FName { get; private set; }
    public string LName { get; private set; }
    public string Phone { get; private set; }
    public string Email { get; private set; }
    public int EmployeeID { get; private set; }
    public Account Account {get; private set; }


    public abstract float CalculatePay();

    public Employee()
    {

    }

    public Employee(string fName, string lName, string phone, string email, int employeeID, Account account)
    {
        FName = fName;
        LName = lName;
        Phone = phone;
        Email = email;
        EmployeeID = employeeID;
        Account = account;

    }
    public Employee(string fName, string lName, string phone, string email, int employeeID)
    {
        FName = fName;
        LName = lName;
        Phone = phone;
        Email = email;
        EmployeeID = employeeID;

    }

    

    public virtual string SaveEmployeeFormat()
    {
        return $"{EmployeeID}~{GetType()}~{FName}~{LName}~{Phone}~{Email}";
    }
   


}