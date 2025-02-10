public class Word
{
    //Attributes
    private string _word;
    private bool _revealed;


    //Initialize
    public Word(string word)
    {
        word = _word;
    }

    //Behaviors
    public void Display()
    {
        Console.WriteLine(_word);
    }

    public void Hide()
    {
        Console.WriteLine("___");
    }

    public bool IsRevealed(bool _revealed)
    {
        return _revealed;
    }


}