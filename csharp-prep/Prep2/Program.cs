using System;

class Program
{
    static void Main(string[] args)
    {

        // Prompt the user to input their grade
        Console.Write("What is your grade percentage?: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
    
        //Use if, else if and else statement to get their grade level
        if ( number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80 )
        {
            letter = " B ";
        }
        else if (number >= 70 )
        {
            letter = " C";
        }
        else if ( number >= 60 )
        {
            letter = "D";
        }
        else 

        {
            letter = "F";
        }

        //Print the user's grade level
        Console.WriteLine ($"Your grade level is {letter} ");

        if ( number >= 70 )
        {
            Console.WriteLine ("Congratulations! You passed!!!");
        }
        else{
            Console.WriteLine ("Try again!! You can do it!");
        }
    }

}