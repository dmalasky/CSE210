using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.Company = "Apple";
        job1.JobTitle = "Software Engineer";
        job1.StartYear = 2001;
        job1.EndYear = 2003;

        Job job2 = new Job();
        job2.Company = "Microsoft";
        job2.JobTitle = "Manager";
        job2.StartYear = 2002;
        job2.EndYear = 2004;


        Resume resume1 = new Resume();
        resume1.Name = "Daniel Malasky";
        resume1.Jobs.Add(job1);
        resume1.Jobs.Add(job2);
        

        resume1.DisplayResume();
        
    }
}