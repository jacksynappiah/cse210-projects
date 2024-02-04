// A class to represent a scripture
class Scripture
{
    // Properties to store the reference and the text as a list of words
    public ScriptureMastery Reference { get; set; }
    public List<ScriptureWord> Text { get; set; }

    // A constructor that takes a reference and a text
    public Scripture(ScriptureMastery reference, string text)
    {
        Reference = reference;
        // Split the text by spaces and punctuation and create a list of words
        Text = new List<ScriptureWord>();
        string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            Text.Add(new ScriptureWord(word));
        }
    }

    // A method to return the scripture as a string
    public override string ToString()
    {
        // Start with the reference
        string result = Reference.ToString() + "\n";
        // Add each word in the text, separated by spaces
        foreach (ScriptureWord word in Text)
        {
            result += word.ToString() + " ";
        }
        // Trim the trailing space and return the result
        return result.Trim();
    }

    // A method to hide a few random words in the scripture
    public void HideWords()
    {
        // Create a random number generator
        Random random = new Random();
        // Choose a random number of words to hide, between 1 and 5
        int wordsToHide = random.Next(1, 6);
        // Repeat for the number of words to hide
        for (int i = 0; i < wordsToHide; i++)
        {
            // Choose a random index in the text list
            int index = random.Next(Text.Count);
            // Set the word at that index to hidden
            Text[index].IsHidden = true;
        }
    }

    // A method to check if all words in the scripture are hidden[^1^][1]
    public bool IsAllHidden()
    {
        // Loop through each word in the text list
        foreach (ScriptureWord word in Text)
        {
            // If any word is not hidden, return false
            if (!word.IsHidden)
            {
                return false;
            }
        }
        // If all words are hidden, return true
        return true;
    }
}