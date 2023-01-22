using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating the list
        List<int> listnumbers = new List<int>();
       
       //Default value of the number that the user will be adding
        int UserNum = -1;
        int sum = 0;
        

        //Checking that the value the user added is not 0
        while (UserNum !=0)
        {
        // Asking the user for the number to be added to the list and making a int
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        string listedNumber = Console.ReadLine();
            UserNum = int.Parse(listedNumber);

            if (UserNum != 0)
            {
                listnumbers.Add(UserNum);
            }

        }

        foreach (int number in listnumbers)
        {
            sum += number;
        }
            Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / listnumbers.Count;
            Console.WriteLine($"The average is: {average}");

        int max = listnumbers[0];
        foreach (int number in listnumbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
        
        
    }
}