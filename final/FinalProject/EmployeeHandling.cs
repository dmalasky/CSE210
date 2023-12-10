using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

// NOTE-TO-SELF: Next time make a function to load EmployeeData.txt into a list and only read from the file once.
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
        Console.WriteLine();

        switch (empType)
        {
            // Create Salary Employee.
            case "1":
                Console.Write("What is their hourly rate? $");
                float salary = float.Parse(Console.ReadLine());
                EmployeeSalary employeeSalary = new EmployeeSalary(fName, lName, phone, email, employeeID, salary);
                EmployeeList.Add(employeeSalary);
                break;

            // Create Hourly Employee.
            case "2":
                Console.Write("What is their hourly rate? $");
                float rate = float.Parse(Console.ReadLine());
                Console.Write("How many hours are they scheduled for? ");
                float hours = float.Parse(Console.ReadLine());
                EmployeeHourly employeeHourly = new EmployeeHourly(fName, lName, phone, email, employeeID, rate, hours);
                EmployeeList.Add(employeeHourly);
                break;

            // Create Comission Employee.
            case "3":
                EmployeeCommission employeeCommission = new EmployeeCommission(fName, lName, phone, email, employeeID);
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

        //temp
       
        SaveEmployee();
        EmployeeList.Clear();
        
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

    // Removes an employee from the system.
    public void RemoveEmployee()
    {
        // Display Employees
        ListEmployees();

        // bools for if and loops        
        bool done = false;
        bool EmployeeFound = false;

        // Continue to ask until the users finds the correct employee to delete.
        do
        {
            Console.Write("Please type the ID of the employee you would like to remove: ");
            string EmpToEdit = Console.ReadLine();
            string filePath = "EmployeeData.txt";


            try
            {
                // open file
                List<string> lines = File.ReadAllLines(filePath).ToList();
                foreach (string line in lines)
                {

                    string[] parts = line.Split("~");
                    string empID = parts[0];

                    // Display and/or remove employee once found.
                    if (EmpToEdit == empID)
                    {
                        EmployeeFound = true;
                        
                        string empType = "";
                        if (parts[1] == "EmployeeSalary")
                        {
                            empType = "Salary";
                        }
                        else if (parts[1] == "EmployeeHourly")
                        {
                            empType = "Hourly";
                        }
                        else if (parts[1] == "EmployeeCommission")
                        {
                            empType = "Commission";
                        }

                        Console.WriteLine($"Empolyee ID: {empID}");
                        Console.WriteLine($"- {parts[2]} {parts[3]}");
                        Console.WriteLine($"- {empType}");
                        Console.WriteLine($"- {parts[4]}");
                        Console.WriteLine($"- {parts[5]}\n");

                        Console.Write($"Are you sure you want to remove {parts[2]} {parts[3]} (y/n)? ");
                        string choice = Console.ReadLine().ToLower();

                        // Are you sure?
                        if (choice == "y")
                        {
                            lines.Remove(line);
                            Console.WriteLine($"{parts[2]} {parts[3]} successfully deleted.");
                            break; // Leaves the loop once employee is deleted.
                        }
                        else if (choice == "n")
                        {
                            Console.WriteLine("\nCanceling...");
                        }
                    }
                }

                // Checks if correct employee is found.
                if (!EmployeeFound)
                {
                    Console.WriteLine($"Employee ID: '{EmpToEdit}' not found. Please try again.");
                }
                else
                {
                    // Overwrites old file
                    using (StreamWriter outputFile = new StreamWriter("EmployeeData.txt"))
                    {
                        foreach (string line in lines)
                        {
                            outputFile.WriteLine(line);
                        }
                    }

                    done = true;
                }

            }
            catch (FileNotFoundException)
            {

            }

        } while (!done);


    }

     public void InputHoursOrJobs()
    {
        ListEmployees();

        List<string> Overwrite = new List<string>();

        bool done = false;
        do
        {
            int employeeIndex = FindEmployeeIndex();
            string filePath = "EmployeeData.txt";

            // Easier string concatination.
            System.Text.StringBuilder nameBuilder = new System.Text.StringBuilder();

            // Add jobs or hours.
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++ )
                {
                    string[] parts = lines[employeeIndex].Split("~");

                    if (i == employeeIndex)
                    {
                        if (parts[1] == "EmployeeHourly")
                        {
                            EmployeeHourly employeeHourly = new EmployeeHourly();
                            Console.Write("How many hours have they worked so far? ");
                            float hoursToAdd = float.Parse(Console.ReadLine());
                            parts[7] = employeeHourly.SetHoursWorked(hoursToAdd).ToString();
                        }
                        else if (parts[1] == "EmployeeCommission")
                        {
                            EmployeeCommission employeeCommission = new EmployeeCommission();
                            employeeCommission.AddJobs();
                            parts[6] = employeeCommission.CurrentPayTotal.ToString();
                        }
                        else if (parts[1] == "EmployeeSalary")
                        {
                            Console.WriteLine("Cannot add jobs/hours to salary employees.");
                            return;
                        }
                        // Creates a string to set line equal to.
                        for (int i_part = 0; i_part < parts.Length; i_part++)
                        {
                            nameBuilder.Append(parts[i_part]);

                            if (i_part < parts.Length -1)
                            {
                                nameBuilder.Append("~");
                            }
                        }
                        lines[i] = nameBuilder.ToString();
                    }
                
                    // creates a list to overwrite old file.
                    Overwrite.Add(lines[i]);
                }

            }
            catch (FileNotFoundException)
            {

            }
            
            // Overwrite old file.
            using (StreamWriter outputFile = new StreamWriter("EmployeeData.txt"))
            {
                foreach (string line in Overwrite)
                {
                    outputFile.WriteLine(line);
                }
            }   
            
            done = true;
        
        } while (!done);
        
    }

    public void EditEmployee() // ADD findemployeeindex.
    {
        // Display employees.
        ListEmployees();

        // New list to overwrite old file.
        List<string> Overwrite = new List<string>();
        
        bool done = false;
        do
        {
            Console.Write("Please type the ID of the employee you would like to edit: ");
            string EmpToEdit = Console.ReadLine();
            string filePath = "EmployeeData.txt";

            // Easier string concatination.
            System.Text.StringBuilder nameBuilder = new System.Text.StringBuilder();

            // Find and edit employee.
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split("~");
                    string empID = parts[0];

                    if (EmpToEdit == empID)
                    {
                        Console.WriteLine($"Empolyee ID: {empID}");
                        Console.WriteLine($"\tName: {parts[2]} {parts[3]}");
                        Console.WriteLine($"\tPhone Number: {parts[4]}");
                        Console.WriteLine($"\tEmail: {parts[5]}");

                        Console.Write("Which part would you like to change? ");
                        string PartToChange = Console.ReadLine().ToLower();

                        if (PartToChange == "name")
                        {
                            Console.WriteLine("Would you like to change the first or last name? ");
                            string NameToChange = Console.ReadLine().ToLower();

                            if (NameToChange == "first" || NameToChange == "first name")
                            {
                                Console.Write("What would you like to change it to? ");
                                string NewName = Console.ReadLine();
                                parts[2] = NewName;
                            }
                            else if (NameToChange == "last" || NameToChange == "last name")
                            {
                                Console.Write("What would you like to change it to? ");
                                string NewName = Console.ReadLine();
                                parts[3] = NewName;
                            }
                            else
                            {
                                Console.WriteLine("Please select first or last name.");
                            }
                        }
                        else if (PartToChange == "phone" || PartToChange == "phone number")
                        {
                            Console.Write("What would you like to change it to? ");
                            string NewPhone = Console.ReadLine();
                            parts[4] = NewPhone;
                        }
                        else if (PartToChange == "email")
                        {
                            Console.Write("What would you like to change it to? ");
                            string NewEmail = Console.ReadLine();
                            parts[5] = NewEmail;
                        }
                        
                        // Creates a string to set line equal to.
                        for (int i_part = 0; i_part < parts.Length; i_part++)
                        {
                            nameBuilder.Append(parts[i_part]);

                            if (i_part < parts.Length -1)
                            {
                                nameBuilder.Append("~");
                            }
                        }
                        lines[i] = nameBuilder.ToString();

                    }
                    
                    // creates a list to overwrite old file.
                    Overwrite.Add(lines[i]);

                }
            
            }
            catch (FileNotFoundException)
            {

            }
            
            // Overwrite old file.
            using (StreamWriter outputFile = new StreamWriter("EmployeeData.txt"))
            {
                foreach (string line in Overwrite)
                {
                    outputFile.WriteLine(line);
                }
            }   

            // Display new employee info.
            Console.WriteLine("\nRevised informaion\n");
            FindAndDisplayEmployee(EmpToEdit);
            done = true;
            // Maybe add an option to ask if it's correct. (will need to make more functions.)

        } while (!done);

    }

    public void ListEmployees()
    {
        
        string filePath = "EmployeeData.txt";
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("\nEmployee List: \n");
            foreach (string line in lines)
            {
                string[] parts = line.Split("~");
                int empID = int.Parse(parts[0]);
                string empType = "";

                if (parts[1] == "EmployeeSalary")
                {
                    empType = "Salary";
                }
                else if (parts[1] == "EmployeeHourly")
                {
                    empType = "Hourly";
                }
                else if (parts[1] == "EmployeeCommission")
                {
                    empType = "Commission";
                }

                Console.WriteLine($"Empolyee ID: {empID}");
                Console.WriteLine($"- {parts[2]} {parts[3]}");
                Console.WriteLine($"- {empType}");
                Console.WriteLine($"- {parts[4]}");
                Console.WriteLine($"- {parts[5]}\n");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No Employees found.");
        }

    }

    // Finds employee based on ID
    public void FindAndDisplayEmployee(string IDToSearchFor)
    {
        string[] lines = File.ReadAllLines("EmployeeData.txt");
        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("~");
            string empID = parts[0];

            if (IDToSearchFor == empID)
            {
                Console.WriteLine($"Empolyee ID: {empID}");
                Console.WriteLine($"\tName: {parts[2]} {parts[3]}");
                Console.WriteLine($"\tPhone Number: {parts[4]}");
                Console.WriteLine($"\tEmail: {parts[5]}");
            }
        }
    }

    // Finds the index of the employee. *** make sure employee exists.
    public int FindEmployeeIndex()
    {
        bool EmployeeFound = false;

        do
        {
            Console.Write("Pleas input an Employee ID, or type 'b' to go back: ");
            string IDToSearchFor = Console.ReadLine();
            if (IDToSearchFor == "b")
            {
                return -1;
            }

            string[] lines = File.ReadAllLines("EmployeeData.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("~");
                string empID = parts[0];
                
                if (IDToSearchFor == empID)
                {
                    EmployeeFound = true;
                    return i;
                }
                
            }
            if (!EmployeeFound)
            {
                Console.WriteLine($"Employee ID: '{IDToSearchFor}' not found. Please try again. Or type 'b' to go back");
            }
        } while (!EmployeeFound);

        return -1;
    }

    // Calculates total pay for all workers.
    public void CalculateAllPay()
    {
        float TotalLaborExpense = 0;
        string[] lines = File.ReadAllLines("EmployeeData.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            
            // Create an employee to access abstract CalculatePay
            if (parts[1] == "EmployeeSalary")
            {
                EmployeeSalary employeeSalary = new EmployeeSalary(float.Parse(parts[6]));
                TotalLaborExpense += employeeSalary.CalculatePay();
            }
            else if (parts[1] == "EmployeeHourly")
            {
                EmployeeHourly employeeHourly = new EmployeeHourly(float.Parse(parts[6]), float.Parse(parts[7]));
                TotalLaborExpense += employeeHourly.CalculatePay();
            }
            else if (parts[1] == "EmployeeCommission")
            {
                EmployeeCommission employeeCommission = new EmployeeCommission(float.Parse(parts[6]));
                TotalLaborExpense += employeeCommission.CalculatePay();
            }
        }

        Console.WriteLine($"\nYour total labor cost is: ${TotalLaborExpense}");

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

    // Calculate pay for one individual.
    public void CalculateIndividualPay()
    {
        // Display Employees.
        ListEmployees();
        
        int EmployeeIndex = FindEmployeeIndex(); // Returns -1 if not found.

        // Cancel calculation if not found.
        if (EmployeeIndex < 0)
        {
            return;
        } 

        // Read file.
        List<string> lines = File.ReadAllLines("EmployeeData.txt").ToList();
        string[] parts = lines[EmployeeIndex].Split("~");

        // Create an employee to access abstract CalculatePay
        if (parts[1] == "EmployeeSalary")
        {
            EmployeeSalary employeeSalary = new EmployeeSalary(float.Parse(parts[6]));
            Console.WriteLine($"Current Pay: employeeSalary.CalculatePay()");
        }
        else if (parts[1] == "EmployeeHourly")
        {
            EmployeeHourly employeeHourly = new EmployeeHourly(float.Parse(parts[6]), float.Parse(parts[7]));
            Console.WriteLine($"Current Pay: employeeHourly.CalculatePay()");
        }
        else if (parts[1] == "EmployeeCommission")
        {
            EmployeeCommission employeeCommission = new EmployeeCommission(float.Parse(parts[6]));
            Console.WriteLine($"Current Pay: {employeeCommission.CalculatePay()}");
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