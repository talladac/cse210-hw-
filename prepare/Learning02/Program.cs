using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer" ;
        job1._company = "Apple";
        job1._startYear = 2001;
        job1._endYear = 2020;


        ;
        Job job2 = new Job();
        job2._jobTitle = "Mechanic" ;
        job2._company = "optimus Prime";
        job2._startYear = 1988;
        job2._endYear = 2030;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



        
    }
}