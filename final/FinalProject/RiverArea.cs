using System.Xml.Serialization;

public class RiverArea : Area
{
    public RiverArea(int irritation, int depression, bool shovel, bool fishpole, bool rock)
        : base(irritation, depression, shovel, fishpole, rock)
    {}
        public void RiverStart()
    {
        if(_moodLevel == MoodState.Neutral)
        {
            Narrator neutralnarrator = new NeutralNarrator();
            neutralnarrator.DescribeEnvironment("river");
            neutralnarrator.DialogueSpeed();
        }
        else if(_moodLevel == MoodState.Angry)
        {
            Narrator angrynarrator = new NeutralNarrator();
            angrynarrator.DescribeEnvironment("river");
            angrynarrator.DialogueSpeed();
        }
        else if(_moodLevel == MoodState.Depressed)
        {
            Narrator depressednarrator = new NeutralNarrator();
            depressednarrator.DescribeEnvironment("river");
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