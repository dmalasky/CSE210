using System;
using System.Data.Common;

// TODO
// X - Make it so only manager can create accounts, they will have to add employees to the system. 
// Add forgot username/password option (use employeeID to find)
// 1. Figure out how to save account information with Employee info
// 2. Make it so when you login all you data is loaded in. 
// Make sure the program flows (reprompts and such )
// 




class Program
{
    static void Main(string[] args)
    {
        AccountHandling accountHandling = new AccountHandling();
        UI uI = new UI();

        // Give user the option to login or create an account.
        // Reprompts user until they select 1 or 2.
        string choice = "";
        do 
        {
            Console.WriteLine("\nWelcome to Payroll, Please login or create an account. Or type 'q' to quit.");
            Console.WriteLine("\t1. Login");
            Console.WriteLine("\t2. Create Account (Manager Only)");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            // Login.
            if (choice == "1")
            {
                bool IsLoggedIn = false;
                bool done = false;

                while (!done)
                {
                    IsLoggedIn = accountHandling.Login();
                    
                    if (IsLoggedIn)
                    {
                        done = true;
                        uI.ShowMainMenu();
                    }
                    else
                    {
                        Console.Write("Would you like to try again? (y/n): ");
                        string tryAgain = Console.ReadLine();

                        if (tryAgain == "n")
                        {
                            done = true;
                        }
                    }
                }
            }
            // Create account.
            else if (choice == "2")
            {
                accountHandling.CreateManagerAccount();
            }
            else if (choice == "q")
            {
                Console.WriteLine("Have a good day!");
            }
            else
            {
                Console.WriteLine("Please select option 1 or 2");
            }
            
        } while (choice.ToLower() != "q" );
    }
}