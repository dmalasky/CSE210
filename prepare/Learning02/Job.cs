using System;
using System.Globalization;

public class Job
{
    public string Company;
    public string JobTitle;
    public int StartYear;
    public int EndYear;
    
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear} - {EndYear}");
    }

}


    