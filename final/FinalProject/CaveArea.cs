public class CaveArea : Area 
{
    public CaveArea(int irritation, int depression, bool shovel, bool fishpole, bool rock)
        : base(irritation, depression, shovel, fishpole, rock)
    {}
    public void CaveStart()
    {
        if(_moodLevel == MoodState.Neutral)
        {
            Narrator neutralnarrator = new NeutralNarrator();
            neutralnarrator.DescribeEnvironment("cave");
            neutralnarrator.DialogueSpeed();
        }
        else if(_moodLevel == MoodState.Angry)
        {
            Narrator angrynarrator = new NeutralNarrator();
            angrynarrator.DescribeEnvironment("cave");
            angrynarrator.DialogueSpeed();
        }
        else if(_moodLevel == MoodState.Depressed)
        {
            Narrator depressednarrator = new NeutralNarrator();
            depressednarrator.DescribeEnvironment("cave");
            depressednarrator.DialogueSpeed();
        }


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        string choice = Console.ReadLine();

        switch(choice)
        {
            case "1":
            break;

            case "2":
            break;

            case "3":
            break;

            case "4":
            break;
        }
    }
}