using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "2D Animater";
        job1._company = "Animate 24";
        job1._startYear = 2021;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Recriuter";
        job2._company = "Kaaf University";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Jackson Appiah";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}