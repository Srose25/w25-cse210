public class Area
{
    //Attributes
    protected int _irritation;
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

    //Behaviors
    public Area(int irritation, int depression, bool shovel, bool fishpole, bool rock)
    {
        this._irritation = irritation;
        this._depression = depression;
        this._shovel = shovel;
        this._fishpole = fishpole;
        this._rock = rock;
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
                    RiverArea rarea1 = new RiverArea(_irritation, _depression, _shovel, _fishpole, _rock);
                    rarea1.RiverStart();
                    break;

                    case "2":
                    GrassArea garea1 = new GrassArea(_irritation, _depression, _shovel, _fishpole, _rock);
                    garea1.GrassStart();
                    break;

                    case "3":
                    CaveArea carea1 = new CaveArea(_irritation, _depression, _shovel, _fishpole, _rock);
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
}