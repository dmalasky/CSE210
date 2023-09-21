using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int userNum = PromptUserNumber();
        int square = SquareNumber(userNum);
        DisplayResult(name, square);

        

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNum = int.Parse(Console.ReadLine());
        
        return userNum;
    }

    static int SquareNumber(int userNum)
    {
        int square = userNum * userNum;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}