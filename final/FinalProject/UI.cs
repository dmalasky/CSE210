public class UI 
{
    // TODO - for employee view
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
    public void ShowMainMenu()
    {
        bool done = false;
        do
        {
        
            bool isManager = true; // temporary, while no employee view.

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
                Console.WriteLine("\nPick one of the following");
                Console.WriteLine("\t1. Input hours/Jobs for an employee");
                Console.WriteLine("\t2. Add Employee");
                Console.WriteLine("\t3. Remove Employee");
                Console.WriteLine("\t4. List Employees");
                Console.WriteLine("\t5. Edit Employee information");
                Console.WriteLine("\t6. Calculate pay for one employee");
                Console.WriteLine("\t7. Calculate pay for all");
                Console.WriteLine("\t8. Logout");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                // Input hours/Jobs for an employee
                case "1":
                    employeeHandling.InputHoursOrJobs();
                    break;

                // Add Employee
                case "2":
                    bool finished = false;
                    do
                    {
                        Console.WriteLine("How will the employee be paid? ");
                        Console.WriteLine("\t1. Salary");
                        Console.WriteLine("\t2. Hourly");
                        Console.WriteLine("\t3. Comission");
                        Console.Write("Choose an option: ");
                        string empType = Console.ReadLine();
                        switch (empType)
                        {
                            case "1":
                            case "2":
                            case "3":
                                employeeHandling.CreateNewEmployee(empType);
                                finished = true;
                                break;
                            default:
                                Console.WriteLine("Invalid input.");
                                break;
                        }
                        
                    } while (!finished);

                    break;

                // Remove Employee
                case "3":
                    employeeHandling.RemoveEmployee();
                    break;

                // List Employees
                case "4":
                    employeeHandling.ListEmployees();
                    break;

                // Edit Employee information
                case "5":
                    employeeHandling.EditEmployee();
                    break;

                // Calculate pay for one employee
                case "6":
                    employeeHandling.CalculateIndividualPay();
                    break;

                // Calculate pay for all
                case "7":
                    employeeHandling.CalculateAllPay();
                    break;
                case "8":
                    return;
                
                default:
                    break;
                }
                
            }
        } while (!done);
    }

 

}