using System;
using System.Data.Common;

class Program
{
    
    
    static void Main(string[] args)
    {
        int guess = 0;
        
        //gets user input for magic num range
        Console.Write("Please input a cap for the magic numner range: ");
        int cap = int.Parse(Console.ReadLine());

        //Generates random number and assigns to magicNum
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, cap);
        

        //loop that continues to reprompt the user until they get the num right
        while(guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            //determines whether the guess is right, lower, or higher than magicNum
            if (guess == magicNum)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
       


    }


}