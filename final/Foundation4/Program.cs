using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(60, 13);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(85, 27);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(610, 50);
        activitiesList.Add(swimming);


        //display activity summaries
        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();
        }
    }
}