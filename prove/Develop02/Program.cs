using System;
using System.IO; 

/*
I included an option to delete the file. It checks if the file exists and then deletes it if it does.
*/

class Program
{
    static void Main(string[] args)
    {
        
      
        string choice = "";
        
        Journal journal = new Journal();
        
        
        while (choice != "5")
        {
            choice = DisplayMenu();

            if (choice == "1")
            {
                // Writes in the journal
                journal.WriteFile(); 
            }
            else if (choice == "2")
            {
                // Display journal entries
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
              // Loads the file into the defined list
              journal.LoadFile();
            }
            else if (choice == "4")
            {
               // Saves the entries to a txt file
               journal.SaveFile();
            }
            else if (choice == "5")
            {
                return;
            }
            else if (choice == "6")
            {
                journal.DeleteFile();
            }

        }

        
        
        
    }

    //Displays Menu
    static string DisplayMenu() 
    {
        
        Console.WriteLine("\nWelcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Delete journal");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        return choice;
    }

    
}

