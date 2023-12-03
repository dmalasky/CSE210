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
        


    public void CreateAccount()
    {

        // TODO
        // Add username taken
        // Add correct reprompting
        // Only ask for manager key when is manager is asked.
        // Add employee ID
        
        string choice = "";
        do 
        {
            
            bool isManager = false;
            isManager = VerifyMangerKey();
        
            
            // Checks if user has manager key and sets isManager.
            
            if (isManager == true)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                // Create and add manager account to AccountList.
                AccountManager accountManager = new AccountManager(username, password, isManager);
                AccountList.Add(accountManager);

                // Add new manager account to AccountData.txt.
                using (StreamWriter outputFile = new StreamWriter("AccountData.txt", true)) // true appends data to file
                {
                    outputFile.WriteLine($"{username}, {password}, {isManager} ");
                }

                choice = "b";  
            }
            
            choice = Console.ReadLine();
            
        
            
        } while (choice != "b");

         
    }


    // Loop this in the previous function. should just say yest or no
    // OR just give them one chance.
    public bool VerifyMangerKey()
    {
        string key = "";
        do
        {
            Console.WriteLine("What is the manager key? (For testing it's '123')");
            key = Console.ReadLine();
            if (key == "123")
            {
                Console.WriteLine("Welcome, please proceed.");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry that is incorrect. Press enter to try again or type 'b' to go back");
                return false;

            }
            

        } while(key != "123");
    }

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
            Console.WriteLine(parts[0]);

            if (parts[0] == username && parts[1] == password)
            {
                return true;
            }
            
        }

        return false;
        
    }


}