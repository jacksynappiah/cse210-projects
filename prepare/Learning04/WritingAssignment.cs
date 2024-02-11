// The WritingAssignment class is a subclass of the Assignment class
public class WritingAssignment : Assignment
{
    // Declaring a private string property _title
    private string _title;

    // Defining a public constructor for the WritingAssignment class that takes three parameters: studentName, topic, and title
    public WritingAssignment(string studentName, string topic, string title)
        // Calling the base class (Assignment) constructor with studentName and topic parameters
        : base(studentName, topic)
    {
        // Assigning the value of title parameter to the _title property
        _title = title;
    }

    // Defining a public method GetWritingInformation that returns a string combining _title and studentName properties
    public string GetWritingInformation()
    {
        // Getting the student name by calling the GetStudentName method from the base class
        string studentName = GetStudentName();

        // Returning a string that combines the title of the writing assignment and the name of the student
        return $"{_title} by {studentName}";
    }
}
