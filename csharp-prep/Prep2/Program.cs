using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
    

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