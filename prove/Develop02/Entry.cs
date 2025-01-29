public class Entry{
    //Attributes


    public string _dateTime = DateTime.Now.ToString("yyyy-MM-dd");
    public string _userInput;
    public List<string> _allPrompts = new List<string>()
    {
        "What was something funny that happened today?",
        "What warmed your heart today?",
        "What did you do today?",
        "What was something you learned today?"
    };
    Random rng = new Random();
    string _myPrompt;

    //Behaviors

    //Function that displays a randomly Generated prompt.
    public void DisplayPrompt()
    {
        int _index = rng.Next(_allPrompts.Count);
        _myPrompt = _allPrompts[_index];

        Console.WriteLine($"{_myPrompt}\n >");
    }

    //Function that gets the input from the user for the Journal Entry
    public string GetInput()
    {
        _userInput = Console.ReadLine();

        return _userInput;
    }

    public string CompileEntry()
    {
        return $"{_dateTime}, {_myPrompt} {_userInput}";
    }
}