using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("daniel", "Book");
        MathAssignment mathAssignment = new MathAssignment("Section 7.3", "Problems 8-19", "Roberto", "Fractions");
        WritingAssignment writingAssignment = new WritingAssignment("WW2 Cause", "Mary", "Europe History");


        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHWList());
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
        

    }
}