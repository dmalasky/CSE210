public class Entry
{
    public string EntryDate {get; set;}
    public string Prompt {get; set;}
    public string Response {get; set;}
    

public void DisplayEntry()
    {
        Console.WriteLine($"Date: {EntryDate} - Prompt: {Prompt}\n{Response}\n");  // adds all three Entry object to a string
    }
}