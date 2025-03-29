public abstract class Narrator()
{
    public enum MoodState
    {
        Neutral = 0,
        Angry = 1,
        Depressed = 2
    }
    protected MoodState _moodLevel = MoodState.Neutral; //Different integer = Different mood
    protected readonly Dictionary<string, List<string>> _dialogue = new Dictionary<string, List<string>>();
    protected readonly Dictionary<string, List<string>> _hint = new Dictionary<string, List<string>>();
    protected readonly Dictionary<string, List<string>> _environment = new Dictionary<string, List<string>>();


    // Core methods
    public void SetMood(MoodState value)
    {
        _moodLevel = value;
    }

    public MoodState GetMood()
    {
        return _moodLevel;
    }


    // Virtual methods
    public virtual string ProvideHint(string key)
    {
        return GetRandomResponse(_hint, key);
    }

    public virtual string DescribeEnvironment(string key)
    {
        return GetRandomResponse(_environment, key);
    }

    public virtual string GetDialogue(string key)
    {
        return GetRandomResponse(_dialogue, key);
    }


    // Utility Method
        public string GetRandomResponse(Dictionary<string, List<string>> dictionary, string key)
    {
        if (dictionary.ContainsKey(key) && dictionary[key].Count > 0)
        {
            Random rnd = new Random();
            return dictionary[key][rnd.Next(dictionary[key].Count)];
        }
        return "The Narrator remains silent.";
    }

}