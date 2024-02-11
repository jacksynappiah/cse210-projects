// Importing the System namespace
using System;

// Defining a public class named Assignment
public class Assignment
{
    // Declaring a private string property _studentName
    private string _studentName {get; set;}
    // Declaring a private string property _topic
    private string _topic {get; set;}

    // Defining a public constructor for the Assignment class that takes two parameters: studentName and topic
    public Assignment(string studentName, string topic)
    {
        // Assigning the value of studentName parameter to the _studentName property
        _studentName = studentName;
        // Assigning the value of topic parameter to the _topic property
        _topic = topic;
    }

    // Defining a public method GetStudentName that returns the value of _studentName property
    public string GetStudentName()
    {
        return _studentName;
    }
    // Defining a public method GetTopic that returns the value of _topic property
    public string GetTopic()
    {
        return _topic;
    }
    // Defining a public method GetSummary that returns a string combining _studentName and _topic properties
    public string GetSummary()
    {
        return _studentName + " -" +  _topic;
    }
}
