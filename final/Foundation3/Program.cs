using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("Independence Ave.", "Accra", "Greater Accra", "GH 00233", "Ghana");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Ananse Stories", "Storytelling event with local elders.", "April 6, 2024", "7:00 pm - 9:00 pm", $"{lectureAddress}", "Lecture", "Elder Anokye", 150);

        //display lecture event details
        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("Kumasi St.", "Kumasi", "Ashanti", "GH 00244", "Ghana");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Ama and Kofi", "Ama and Kofi's traditional wedding ceremony and reception", "June 11, 2024", "2:00 pm - 10:00pm", $"{receptionAddress}", "Reception", "amakofi@gmail.com");
        
        //display reception event details
        Console.WriteLine("---------------------------------------------------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


Address address3 = new Address ("Labadi Beach Rd", "Accra", "Greater Accra", "GH 00233", "Ghana");
string outdoorAddress = address3.GetAddress();
Outdoor outdoor = new Outdoor("Beach Soccer", "Beach soccer event for all youth.", "July 20, 2024", "4:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");
//display outdoor event details
Console.WriteLine("---------------------------------------------------------------------------");

        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
    }
}