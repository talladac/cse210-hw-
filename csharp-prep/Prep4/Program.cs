using System;
using System.ComponentModel;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Print the instruction
        Console.WriteLine("Enter a list of numbers, type 0  when finished.");
        
        List<int> numbers = new List<int>();
        int UserNumber = -1;
        int inputNumber = 0;

        //Use the while loop to prompt the user to input number until he types 0
        while (UserNumber != 0 )
        {
             Console.Write("Enter a number: ");
            UserNumber = int.Parse(Console.ReadLine());
            


        if (UserNumber != 0 )
        {
            // for storing the user input numbers
            numbers.Add(UserNumber); 
            inputNumber ++; 
        }
             
        }
        //Core Requirement 1 (Compute the sum, or total, of the numbers in the list.)
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        //Core Requirement 2 (Compute the average of the numbers in the list.)
        float average = ((float)sum) / inputNumber;

        // Core Requirement 3 (Find the maximum, or largest, number in the list.)
        int maximum = numbers [0];
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
    }

}