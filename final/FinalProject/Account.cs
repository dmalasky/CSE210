using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Account 
{
    public string Username { get; private set; }    
    public string Password { get; private set; }
    public bool IsManager { get; private set; }    

    public Account()
    {

    }
    public Account(string username, string password, bool isManager)
    {
        Username = username;
        Password = password;
        IsManager = isManager;
    }

    public void SetIsManager(bool isManager)
    {
        IsManager = isManager;
    }

    // Formatting for saving data.
    public virtual string SaveAccountFormat()
    {
        return $"{Username}~{Password}~{IsManager}";
    }
    
}