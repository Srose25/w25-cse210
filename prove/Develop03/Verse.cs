public class Verse
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

    public void HideWords(int difficulty)
    {
        //Create a switch case that converts the users input into a difficulty setting
        Random rng = new Random();
        switch (difficulty)
        {
            case 1:
            difficulty = 1;
            break;
            
            case 2:
            difficulty = 3;
            break;

            case 3:
            difficulty = 5;
            break;
        }

        //Create a method that picks the amount of difficulty of words in the sentence to hide
        List<int> chosenIndexes = new List<int>();

        while (chosenIndexes.Count < difficulty)
        {
            int randomIndex = rng.Next(_wordList.count);
            
        }
    }


    public void GetVerseText() //don't leave void
    {

    }
}