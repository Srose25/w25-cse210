public class Journal {

    //Attributes
    public List<string> _entryList = new List<string>();


    //Behaviors

    //This function calls our Entry class
    public string Initialize()
    {
        Entry newEntry = new Entry();

        newEntry.DisplayPrompt();
        newEntry.GetInput();
        Console.WriteLine(newEntry.CompileEntry());

        return newEntry.CompileEntry();
    }

    //This function Adds each compiled entry to a list
    public void AppendEntry()
    {

        Entry newEntry = new Entry();

        newEntry.DisplayPrompt();
        newEntry.GetInput();
        Console.WriteLine(newEntry.CompileEntry());

        string compiledEntry = newEntry.CompileEntry();
        _entryList.Add(compiledEntry);
    }

    //This function Displays the journal
    public void DisplayJournal()
    {
        Console.WriteLine("Your Journal Entries:\n");
        foreach (string entry in _entryList)
        {
            Console.WriteLine(entry);
        }
    }
}