public class Area
{
    //Attributes
    protected int _depression;
    protected bool _shovel;
    protected bool _fishpole;
    protected bool _rock;
    public enum MoodState
    {
        Neutral = 0,
        Angry = 1,
        Depressed = 2
    }
    protected MoodState _moodLevel = MoodState.Neutral; //Different integer = Different mood

    protected int _locket;
    protected int _picture;                             // 1 = you've collected it
    protected int _musbox;                              // 2 = it's broken

    protected bool _Gkey;
    protected bool _Rkey;
    protected bool _Ckey;

    //Behaviors
    public Area(int depression, bool shovel, bool fishpole, bool rock, int locket, int picture, int musbox, bool Gkey, bool Rkey, bool Ckey)
    {

        this._depression = depression;
        this._shovel = shovel;
        this._fishpole = fishpole;
        this._rock = rock;
        this._locket = locket;
        this._picture = picture;
        this._musbox = musbox;
        this._Gkey = Gkey;
        this._Rkey = Rkey;
        this._Ckey = Ckey;
    }

    public void Start()
    {
        //Beginning monologue and exposition
        AreaMenu();
    }

    public void AreaMenu()
    {
        bool running = true;
        while(running)
        {
            Console.Clear();
            Console.WriteLine("Menu:\n");
            Console.WriteLine("1. Look Around"); //Menu options
            Console.WriteLine("2. Inventory");
            Console.WriteLine("3. ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":   //Look Around
                Console.WriteLine("Where would you like to look around?\n");
                Console.WriteLine("1. River Area");
                Console.WriteLine("2. Grass Area");
                Console.WriteLine("3. Cave Area");
                string area_choice = Console.ReadLine();

                switch(area_choice)
                {
                    case "1":
                    RiverArea rarea1 = new RiverArea( _depression, _shovel, _fishpole, _rock, _locket, _picture, _musbox, _Gkey, _Rkey, _Ckey);
                    rarea1.RiverStart();
                    break;

                    case "2":
                    GrassArea garea1 = new GrassArea(_depression, _shovel, _fishpole, _rock, _locket, _picture, _musbox, _Gkey, _Rkey, _Ckey);
                    garea1.GrassStart();
                    break;

                    case "3":
                    CaveArea carea1 = new CaveArea(_depression, _shovel, _fishpole, _rock, _locket, _picture, _musbox, _Gkey, _Rkey, _Ckey);
                    carea1.CaveStart();
                    break;

                    default:
                    Console.WriteLine("Invalid Option.");
                    break;
                }
                break;

                case "2":   //Inventory
                break;

                case "3":   //Unlock the Box / end the game
                if (_Gkey && _Rkey && _Ckey)
                {
                    End();
                }
                break;

                case "4":   //End the game early
                running = false;
                break;
            }

            
        }
    }

    public void End()
    {
        //What happens when you open the box / end monologue
    }


    //Utility Methods
    public void SetMood(MoodState value)
    {
        _moodLevel = value;
    }

    public MoodState GetMood()
    {
        return _moodLevel;
    }
    public void PrintResponse(string key)
    {
                if(_moodLevel == MoodState.Neutral)
        {
            Narrator neutralnarrator = new NeutralNarrator();
            string rndresponse = neutralnarrator.GetDialogue(key);
            neutralnarrator.DialogueSpeed(rndresponse);
        }
        else if(_moodLevel == MoodState.Angry)
        {
            Narrator angrynarrator = new NeutralNarrator();
            string rndresponse = angrynarrator.GetDialogue(key);
            angrynarrator.DialogueSpeed(rndresponse);
        }
        else if(_moodLevel == MoodState.Depressed)
        {
            Narrator depressednarrator = new NeutralNarrator();
            string rndresponse = depressednarrator.GetDialogue(key);
            depressednarrator.DialogueSpeed(rndresponse);
        }
    }
}