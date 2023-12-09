public class UI 
{
    // TODO
    // Will prob need separate menus for each employeeType
    // Salary
    //  1. Show hourly rate
    //  2. Calculate pay
    // Hourly
    //  same without jobs
    // Commission
    //  same without hours
    
    
    EmployeeHandling employeeHandling = new EmployeeHandling();
    public UI()
    {

    }

    // Displays employee menu.
    public void ShowMainMenu(bool isManager)
    {
        // Employee view.
        if (isManager == false)
        {
            Console.WriteLine("Pick one of the following");
            Console.WriteLine("\t1. Input hours/Jobs");
            Console.WriteLine("\t2. View current hours/jobs");
            Console.WriteLine("\t3. CalculatePay");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                // Input hours/Jobs
                case "1":
                    break;
                
                // View current hours/jobs
                case "2":
                    break;

                // CalculatePay
                case "3":
                    break;

                default:
                    break;
            }
 
        }

        // Manager view.
        else
        {
            Console.WriteLine("Pick one of the following");
            Console.WriteLine("\t1. Input hours/Jobs for an employee");
            Console.WriteLine("\t2. Add Employee");
            Console.WriteLine("\t3. Remove Employee");
            Console.WriteLine("\t4. List Employees");
            Console.WriteLine("\t5. Edit Employee information");
            Console.WriteLine("\t6. Calculate pay for one employee");
            Console.WriteLine("\t7. Calculate pay for all"); // list all employees and pay, maybe with total
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
                       switch (choice)
            {
            // Input hours/Jobs for an employee
            case "1":
                
                break;

            // Add Employee
            case "2":
                
                Console.WriteLine("How will the employee be paid? ");
                Console.WriteLine("\t1. Salary");
                Console.WriteLine("\t2. Hourly");
                Console.WriteLine("\t3. Comission");
                Console.Write("Choose an option: ");
                string empType = Console.ReadLine();
                employeeHandling.CreateNewEmployee(empType);
                

                break;

            // Remove Employee
            case "3":
                break;

            // List Employees
            case "4":
                employeeHandling.ListEmployees();
                break;

            // Edit Employee information
            case "5":
                break;

            // Calculate pay for one employee
            case "6":
                break;

            // Calculate pay for all
            case "7":
                break;

            default:
                break;
            }

            
            
        }

    }




    // *** Move these into showmainmenu ***
    // public void PickManagerMenuOption(string choice)
    // {
        
    // }

    // public void PickEmployeeMenuOption(string choice)
    // {
        
    // }
    

}