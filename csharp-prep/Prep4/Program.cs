using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Schema;


class Program
{
    static void Main(string[] args)
    {
        //Initialize variables
        bool isZero = false;
        List<int> numbers = new List<int>();
        int total = 0;
        float avg = 0;
        int maxNum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //Continues to prompt the user for numbers until the user inputs 0
        while  (isZero == false)
        {
            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());
            numbers.Add(userInput);
            
            //Decides when the loop ends by making isZero true
            if (userInput == 0)
            {
                isZero = true;
            }
        }

        //Loop to iterate through list to determine max and total
        foreach (int num in numbers)
        {
            total = num + total;

            //Determines maxNum
            if (maxNum < num)
            {
                maxNum = num;
            }
        }
        
        //Calcs avgs
        Console.WriteLine(numbers.Count);
        avg = (float)total / (numbers.Count - 1);

        //Prints results
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {maxNum}");


    }
}