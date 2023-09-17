using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade? ");
        string grade = Console.ReadLine();
        int gradeNum = int.Parse(grade); 

        string letter = " "; 

        if (gradeNum > 89 )
        {
            letter = "A";
        }
        else if (gradeNum > 79)
        {
            letter = "B";
        }
          else if (gradeNum > 69)
        {
            letter = "C";
        }
          else if (gradeNum > 59)
        {
            letter = "D";
        }
          else if (gradeNum < 60)
        {
            letter = "F";
        }

        string results = " ";

          if (gradeNum <= 69  )
        {
            results = "You failed the class, You'll have a headstart next year.";
        }
        else if (gradeNum > 69)
        {
            results = "You Passed, Congrats!";
        }

        Console.WriteLine($"Grade: {letter} \n{results}");
    }
}