// A class to represent a word in the scripture
class ScriptureWord
{
    // Properties to store the word and whether it is hidden or not
    public string Word { get; set; }
    public bool IsHidden { get; set; }

    // A constructor that takes a word and sets it to not hidden by default
    public ScriptureWord(string word)
    {
        Word = word;
        IsHidden = false;
    }

    // A method to return the word as a string
    public override string ToString()
    {
        // If the word is hidden, return a series of underscores
        if (IsHidden)
        {
            return new string('_', Word.Length);
        }
        // Otherwise, return the word itself
        else
        {
            return Word;
        }
    }
}