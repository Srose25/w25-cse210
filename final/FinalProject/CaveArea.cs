public class CaveArea : Area 
{
    public CaveArea(int depression, bool shovel, bool fishpole, bool rock, int locket, int picture, int musbox, bool Gkey, bool Rkey, bool Ckey)
        : base(depression, shovel, fishpole, rock, locket, picture, musbox, Gkey, Rkey, Ckey)
    {}
    public void CaveStart()
    {
        Console.Clear();
        if(_moodLevel == MoodState.Neutral)
        {
            Narrator neutralnarrator = new NeutralNarrator();
            string rndresponse = neutralnarrator.DescribeEnvironment("cave");
            neutralnarrator.DialogueSpeed(rndresponse);
        }
        else if(_moodLevel == MoodState.Angry)
        {
            Narrator angrynarrator = new NeutralNarrator();
            string rndresponse = angrynarrator.DescribeEnvironment("cave");
            angrynarrator.DialogueSpeed(rndresponse);
        }
        else if(_moodLevel == MoodState.Depressed)
        {
            Narrator depressednarrator = new NeutralNarrator();
            string rndresponse = depressednarrator.DescribeEnvironment("cave");
            depressednarrator.DialogueSpeed(rndresponse);
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