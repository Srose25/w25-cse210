public class GrassArea : Area
{
    public GrassArea(int irritation, int depression, bool shovel, bool fishpole, bool rock)
        : base(irritation, depression, shovel, fishpole, rock)
    {}
        public void GrassStart()
    {
        if(_moodLevel == MoodState.Neutral)
        {
            Narrator neutralnarrator = new NeutralNarrator();
            neutralnarrator.DescribeEnvironment("grass");
            neutralnarrator.DialogueSpeed();
        }
        else if(_moodLevel == MoodState.Angry)
        {
            Narrator angrynarrator = new NeutralNarrator();
            angrynarrator.DescribeEnvironment("grass");
            angrynarrator.DialogueSpeed();
        }
        else if(_moodLevel == MoodState.Depressed)
        {
            Narrator depressednarrator = new NeutralNarrator();
            depressednarrator.DescribeEnvironment("grass");
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