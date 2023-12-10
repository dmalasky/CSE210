public class AccountHandling 
{


    Account account = new Account();
    List<Account> AccountList = new List<Account>();


    public AccountHandling()
    {

    }



    



    
    public void StartMenu()
    {
    }  
        

    
    public void CreateManagerAccount()
    {

        // TODO
        // Add username taken
        // Add correct reprompting
        // Add employee ID
        
        string managerKey = "";
        do 
        {
            
            Console.Write("What is the manager key? (For testing it's '123'): ");
            managerKey = Console.ReadLine();

            bool isManager = false;
            isManager = VerifyMangerKey(managerKey);

            
            // Checks if user has manager key and sets isManager.
            if (isManager == true)
            {
                Console.WriteLine("Welcome, please proceed.\n");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                // Create and add manager account to AccountList.
                Account managerAccount = new Account(username, password, isManager);
                AccountList.Add(managerAccount);



                // Add new manager account to AccountData.txt.
                using (StreamWriter outputFile = new StreamWriter("AccountData.txt", true)) // true appends data to file
                {
                    outputFile.WriteLine($"{username}, {password}, {isManager} ");
                }
                
                // Ends the function.
                managerKey = "b";
                
            }
            else
            {
                Console.WriteLine("\nSorry that is incorrect. Please try again or type 'b' to go back.\n");
            }
            
            
            
        
            
        } while (managerKey != "b");

         
    }

    // Returns true if user has the manager key, false otherwise.
    public bool VerifyMangerKey(string key)
    {
        do
        {
            if (key == "123")
            {
                return true;
            }
            else
            {
                return false;
            }  

        } while(key != "123");
    }

    // Returns true if info is good
    public bool Login()
    {
        
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        string[] lines = File.ReadAllLines("AccountData.txt");
        
        // Iterates through the file,
        foreach (string line in lines)
        {
            
            string[] parts = line.Split(", ");

            if (parts[0] == username && parts[1] == password)
            {
                Console.WriteLine("Authenticated.");

                return true;
            }
            
        }
        Console.WriteLine("Incorrect username or password, please try again.\n");

        return false;
        
    }


    


}