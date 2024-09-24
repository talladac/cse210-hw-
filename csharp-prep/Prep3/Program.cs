using System;

class Program
{
    static void Main(string[] args)
    {

        // Print a welcome message
        Console.WriteLine("Hello, welcome to 'The Number Guessing Game!");
        Console.WriteLine("Guess a number between 1-100");

        //Part 1 and 2 Core Requirements
        //Console.Write("What is the magic number?");
        //int magic = int.Parse(Console.ReadLine());

        //Part 3 Core requirement
        Random random = new Random();
        int magic = random.Next(1, 101);
        int tries = 0;


        int guess = -1;

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            tries ++;

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("That is corect!");
                Console.WriteLine($"Number of tries: {tries} times");
            }


        }
    }
}