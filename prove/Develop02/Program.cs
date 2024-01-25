// This is the declaration of the Program class. It's the entry point for the application.
public class Program
{
    // The Main method is the entry point of a application. When the application is started, the Main method is the first method that is invoked.
    public static void Main()
    {
        // Here we're creating a new instance of the Journal class. The 'var' keyword is used to implicitly type the variable 'journal'. The actual type of 'journal' is determined by the compiler as 'Journal'.
        var journal = new Journal();

        // We're calling the Run method on the 'journal' object. The Run method is defined in the Journal class and contains the main loop of the application, which presents a menu to the user and performs actions based on the user's choice.
        journal.Run();
    }
}
