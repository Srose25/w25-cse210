public class Verse()
{

    //Attributes
    private List<Word> _wordList;

    //Initialize

    public Verse(string sentence)
    {
        _wordList = new List<Word>();
        string[] words = sentence.Split(' '); // Split sentence into words

        foreach (string word in words)
        {
            _wordList.Add(new Word(word)); // Add each word to the list
        }
    }
    //Behaviors
}