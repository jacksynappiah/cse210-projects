// A class to represent a scripture reference
class ScriptureMastery
{
    // Properties to store the book, chapter, and verse(s)
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int StartVerse { get; set; }
    public int EndVerse { get; set; }

    // A constructor for a single verse
    public ScriptureMastery(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = verse;
    }

    // A constructor for a verse range
    public ScriptureMastery(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    // A method to return the reference as a string
    public override string ToString()
    {
        // If the start and end verses are the same, return a single verse format
        if (StartVerse == EndVerse)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        // Otherwise, return a verse range format
        else
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }
}