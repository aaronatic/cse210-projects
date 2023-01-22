using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 101);
        int gNumber = -1;

        while (gNumber != mNumber)
        {

        Console.WriteLine("What is your guess?");
        gNumber = int.Parse(Console.ReadLine());

        if (gNumber < mNumber)
        {Console.WriteLine("Higher"); }
        else if (gNumber > mNumber)
        {Console.WriteLine("Lower"); }
        else
        {Console.WriteLine("That is exactly right"); }
        
        }
    }
}