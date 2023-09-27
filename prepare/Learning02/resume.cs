using System;

public class Resume
{
    public string Name;
    public List<Job> Jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine("Jobs: ");
        
        foreach (Job job in Jobs)
        {
            job.DisplayJobDetails();   
        }
        Console.WriteLine();
    }
}