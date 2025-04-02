using System.Media;
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
        Depressed = 1,
        Angry = 2
    }
    protected MoodState _moodLevel = MoodState.Neutral; //Different integer = Different mood

    protected bool _locket;
    protected bool _picture;                             
    protected bool _musbox;                              

    protected bool _Gkey;
    protected bool _Rkey;
    protected bool _Ckey;

    protected List<string> _inventory;

    //Behaviors
    public Area(int depression, bool shovel, bool fishpole, bool rock, bool locket, bool picture, bool musbox, bool Gkey, bool Rkey, bool Ckey)
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

        _inventory = new List<string>{};
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
            Console.WriteLine("3. Unlock the Box");
            Console.WriteLine("4. Quit");
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
                Console.Clear();
                Console.WriteLine("Inventory:");
                if (_inventory.Count == 0)
                {
                    Console.WriteLine("Your inventory is empty.");
                }
                else
                {
                    for (int i = 0; i < _inventory.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {_inventory[i]}");
                    }
                }
                Console.ReadLine();
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
    public void SetMood()
    {
        if(_depression == 0 || _depression == 1)
        {
            _moodLevel = MoodState.Neutral;
        }
        else if(_depression == 2)
        {
            _moodLevel = MoodState.Depressed;
        }
        else if(_depression == 3)
        {
            _moodLevel = MoodState.Angry;
        }
    }

    public void CollectItem(string item)
    {
        _inventory.Add(item);
    }

    public void PrintResponse(string key)
    {
        if(_moodLevel == MoodState.Neutral)
        {
            Narrator neutralnarrator = new NeutralNarrator();
            string rndresponse = neutralnarrator.GetDialogue(key);
            neutralnarrator.DialogueSpeed(rndresponse);
        }
        else if(_moodLevel == MoodState.Depressed)
        {
            Narrator depressednarrator = new NeutralNarrator();
            string rndresponse = depressednarrator.GetDialogue(key);
            depressednarrator.DialogueSpeed(rndresponse);
        }
        else if(_moodLevel == MoodState.Angry)
        {
            Narrator angrynarrator = new NeutralNarrator();
            string rndresponse = angrynarrator.GetDialogue(key);
            angrynarrator.DialogueSpeed(rndresponse);
        }
    }
    public void PlaySound(string key)
    {
        try
        {
            SoundPlayer player = new SoundPlayer(key);
            player.Play();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to play sound: {ex.Message}");
        }
    }
}