using System;

// TODO
// X - Make it so only manager can create accounts, they will have to add employees to the system. 
// Add forgot username/password option (use employeeID to find)
// 1. Figure out how to save account information with Employee info
// Make the calculate pay functions
// add an option to quit the program.
// 2. Make it so when you login all you data is loaded in. 
// Make sure the program flows (reprompts and such )


class Program
{
    static void Main(string[] args)
    {
        AccountHandling accountHandling = new AccountHandling();
        UI uI = new UI();
        EmployeeHandling employeeHandling = new EmployeeHandling();

        
        
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
                Account CurrentUser = accountHandling.Login();
                
                // Reprompts if wrong info.
                if (CurrentUser == null)
                {
                    choice = ""; 
                }

                uI.ShowMainMenu(CurrentUser.IsManager);
                
            }
            else if (choice == "2")
            {
                accountHandling.CreateManagerAccount();
                // Have code reprompt if user selects 'b' inside this function.
                
            }
            else
            {
                Console.WriteLine("Please select option 1 or 2");
            }
            
        } while (choice != "1" && choice != "2");
        
    
    }
}