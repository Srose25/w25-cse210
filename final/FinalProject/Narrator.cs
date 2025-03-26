public abstract class Narrator()
{
    public enum MoodState
    {
        Neutral = 0,
        Angry = 2,
        Depressed = 1
    }
    protected MoodState _moodLevel = MoodState.Neutral; //Different integer = Different mood
    protected readonly Dictionary<string, List<string>> _memory = new Dictionary<string, List<string>>();
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


    // Abstract methods
    public abstract string ProvideHint(string key);
    public abstract string DescribeEnvironment(string key);
    public virtual string GetDialogue(string key)
    {
        if (_dialogue.ContainsKey(key) && _dialogue[key].Count > 0)
        {
            List<string> options = _dialogue[key];
            Random rnd = new Random();
            return options[rnd.Next(options.Count)];
        }
        return "The Narrator has nothing to say.";
    }
}