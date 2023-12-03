using System;

// TODO
// Make it so only manager can create accounts, they will have to add employees to the system.
// Add forgot username/password option (use employeeID to find)
// Add an employee type to each account. OR maybe combine Account into Employee , not sure yet.
// Make the calculate pay functions


class Program
{
    static void Main(string[] args)
    {
        AccountHandling accountHandling = new AccountHandling();
        AccountEmployee accountEmployee = new AccountEmployee();
        AccountManager accountManager = new AccountManager();


        
        
        // Give user the option to login or create an account.
        // Reprompt user until they select 1 or 2.
        string choice = "";
        do 
        {
            Console.WriteLine("\nWelcome to Payroll, Please login or create an account.");
            Console.WriteLine("\t1. Login");
            Console.WriteLine("\t2. Create Account (Manager Only)");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                if (accountHandling.Login() == true)
                {
                    Console.WriteLine("Authenticated.");
                    accountEmployee.ShowMenu();
                    

                }
                else
                {
                    Console.WriteLine("Incorrect username or password, please try again.\n");
                    choice = ""; // reprompt
                }
                
            }
            else if (choice == "2")
            {
                accountHandling.CreateAccount();
                // Have code reprompt if user selects 'b' inside this function.
                
            }
            else
            {
                Console.WriteLine("Please select option 1 or 2");
            }
            
        } while (choice != "1" && choice != "2");
        
    
    }
}