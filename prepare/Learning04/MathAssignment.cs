// The MathAssignment class is a subclass of the Assignment class
public class MathAssignment : Assignment
{
    // Declaring a private string property _textbookSection
    private string _textbookSection;
    // Declaring a private string property _problems
    private string _problems;

    // Defining a public constructor for the MathAssignment class that takes four parameters: studentName, topic, textbookSection, and problems
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        // Calling the base class (Assignment) constructor with studentName and topic parameters
        : base(studentName, topic)
    {
        // Assigning the value of textbookSection parameter to the _textbookSection property
        _textbookSection = textbookSection;
        // Assigning the value of problems parameter to the _problems property
        _problems = problems;
    }

    // Defining a public method GetHomeworkList that returns a string combining _textbookSection and _problems properties
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
