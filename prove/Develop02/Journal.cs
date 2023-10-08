using System;
using System.IO; 

public class Journal
{
    public List<Entry> Entries = new List<Entry>();
    
    
    PromptGenerator prompt = new PromptGenerator();

    // Writes the user input to a list of entries
    public void WriteFile()
    {
        
    
        Entry entry = new Entry();
        entry.Prompt = prompt.RandPrompt(); // Saves random prompt to Entry object
        Console.WriteLine(entry.Prompt);    // Prints Propmt for user
        entry.Response = Console.ReadLine(); // Gets users response, saves to Entry object
        entry.EntryDate = DateTime.Now.ToShortDateString(); // Generates the entry date, saves to Entry object
        
        Entries.Add(entry);
    }

    // Loads a previously written .txt file
    public void LoadFile()
    {
        
        Console.Write("What is the filename? (include .txt) ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            
            Entry entry = new Entry();
            entry.EntryDate = parts[0];
            entry.Prompt = parts[1];
            entry.Response = parts [2];

            Entries.Add(entry);
                
                
        }
    }

    //saves entries into a .txt file
    public void SaveFile()
    {
        
        
        Console.Write("What is the filename? (include .txt) ");
        string fileName = Console.ReadLine();
            

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            
            foreach (Entry entry in Entries) 
                
                outputFile.WriteLine($"{entry.EntryDate}~{entry.Prompt}~{entry.Response}");
                
        }
    }

    // Shows the entries in the journal
    public void DisplayJournal()
    {
        
        foreach (Entry entry in Entries)
        { 
            entry.DisplayEntry();
            
        }

    }

    // Deletes selected file
    public void DeleteFile()
    {
        Console.WriteLine("What is the filename? (include .txt) ");
        string fileName = Console.ReadLine();

        string filePath = Path.GetFullPath(fileName);

        try
        {
            // Checks to see if the file exists
            if(File.Exists(filePath))
            {
                //Delete the file
                File.Delete(filePath);
                Console.WriteLine($"\n{fileName} was deleted successfully");

            }
            else
            {
                Console.WriteLine("\nFile does not exist.");
            }
        }
        catch (IOException error)
        {
            Console.WriteLine(error.Message);
        }
    }

    
}