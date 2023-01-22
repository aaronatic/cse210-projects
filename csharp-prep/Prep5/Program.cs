using System;

class Program
{
    static void Main(string[] args)
    {
        //I run the first function which is just an intor
       DisplayWelcomeMessage();

    //Here I store the returned value from the function AskUserName
    string userName = AskUserName();

    //Here I store the returned value from the function AskUserNumber
    int userNumber = AskUserNumber();

    //Here I store the returned value from the function SquaredNumber but I added the returned value from AskUserNumber function (now stored in userNumber) as property.
    int sqNumber = SquaredNumber(userNumber);

    DisplayResult(userName, sqNumber);
    
    //Intro function
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
     //This is the function that will ask the user and it will return the name
     static string AskUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int AskUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    //Function to square numbers, the number had to be defined
    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

     static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    }

}   