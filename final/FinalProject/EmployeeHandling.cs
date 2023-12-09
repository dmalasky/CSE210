public class EmployeeHandling 
{
    private AccountHandling accountHandling = new AccountHandling();
    
    List<Employee> EmployeeList = new List<Employee>();

    public EmployeeHandling()
    {

    }

    public void CreateNewEmployee(string empType)
    {
        Console.Write("First Name: ");
        string fName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lName = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.WriteLine();
        int employeeID = GenerateEmployeeID();
        Account account = accountHandling.CreateEmployeeAccount();
        Console.WriteLine();
        
        switch (empType)
        {
            // Create Salary Employee.
            case "1":
                Console.Write("What is their hourly rate? $");
                float salary = float.Parse(Console.ReadLine());
                EmployeeSalary employeeSalary = new EmployeeSalary(fName, lName, phone, email, employeeID, account, salary);
                EmployeeList.Add(employeeSalary);
                break;

            // Create Hourly Employee.
            case "2":
                Console.Write("What is their hourly rate? $");
                float rate = float.Parse(Console.ReadLine());
                Console.Write("How many hours are they scheduled for? ");
                float hours = float.Parse(Console.ReadLine());
                EmployeeHourly employeeHourly = new EmployeeHourly(fName, lName, phone, email, employeeID, account, rate, hours);
                EmployeeList.Add(employeeHourly);
                break;

            // Create Comission Employee.
            case "3":
                EmployeeCommission employeeCommission = new EmployeeCommission(fName, lName, phone, email, employeeID, account);
                EmployeeList.Add(employeeCommission);
                break;

            // Error handling.  
            default:
            {
                Console.WriteLine("Please select option 1-3");
                break;
            }           
        }
        Console.WriteLine($"\n{fName}'s account was successfully created!");
        Console.WriteLine("Inform commission employees it is their responsibility to record their jobs, so that they may be paid correct wages.");
        Console.WriteLine(employeeID);

        //temp
        foreach (Employee emp in EmployeeList)
        {
            SaveEmployee();
        }
        // Create save function.
    }

    // Creates new manager account.
    public void CreateNewManger()
    {
        Console.Write("First Name: ");
        string fName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lName = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.WriteLine();
        int employeeID = GenerateEmployeeID();
        Console.WriteLine();
             
        Console.Write("What is their hourly rate? $");
        float salary = float.Parse(Console.ReadLine());
        EmployeeSalary employeeSalary = new EmployeeSalary(fName, lName, phone, email, employeeID, salary);
        EmployeeList.Add(employeeSalary);
                
           
        Console.WriteLine($"\n{fName}'s account was successfully created!");
        
        Console.WriteLine(employeeID);

        //temp
        foreach (Employee emp in EmployeeList)
        {
            SaveEmployee();
        }
        // Create save function.
    }

    // Generates a random Employee id.
    public int GenerateEmployeeID()
    {
        int NewID = 1000;
        
        string filePath = "EmployeeData.txt";
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("File read");
        
            // Generates new IDs until an original is found.
            while (IsEmployeeIDTaken(NewID, lines))
            {
                NewID = GenerateRandomEmployeeID();
            } 
            
            return NewID;
        }
        catch (FileNotFoundException)
        {
            
        }
        return 1000;
    }

    // Checks if employee id is taken.
    private bool IsEmployeeIDTaken(int idToCheck, string[] lines)
    {
        foreach (string line in lines)
        {
            // Split lines up by ~
            string[] parts = line.Split("~");
            int existingID = int.Parse(parts[0]);

            if (idToCheck == existingID)
            {
                return true; // ID is taken, generate a new one
            }
        }

        return false; // ID is not taken
    }

    // Generates a random ID.
    public int GenerateRandomEmployeeID()
    {
        Random _rdm = new Random();
        return _rdm.Next(1000, 9999);    
    }

    public void RemoveEmployee()
    {
        // TODO
        // call ListEmployees
        // Read the file find the name matched by the number. (or empID)
        // Delete the employee from the file
        // Prob clear EmployeeList idk.
    }
    public void EditEmployee()
    {
        // TODO
        // Call ListEmployees
        // prompt for employee id to edit
        // ask which object they want to change.
        // change it in the txt file.
        // Display the users new info.
    }
    public void ListEmployees()
    {
        // TODO
        // Read file into EmployeeList
        // Create a formatted string function to display. (numbered 1-n)
        // Iterate through and display all employees.
        // PROB clear EmployeList idk.

        // Proof of concept.
        string filePath = "EmployeeData.txt";
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            
        }
        catch (FileNotFoundException)
        {
            
        }

    }
    public void CalculateAllPay()
    {
        // Loop through EmployeeList and calculate total money owed.
    }
    
    public void SaveEmployee()
    {
        using (StreamWriter outputFile = new StreamWriter("EmployeeData.txt", true)) // true appends data to file
        {
            foreach (Employee emp in EmployeeList)
            {  
                outputFile.WriteLine(emp.SaveEmployeeFormat());
            }
        }
    }
    
    // For Employee menu

    public void AddHours()
    {
        // Ask how many hours they worked.
        // Compare to hours they have scheduled
    }






    // Add if I have time.
    public void VerifyPhone()
    {
        
    }
    public void VerifyEmail()
    {

    }


    


}