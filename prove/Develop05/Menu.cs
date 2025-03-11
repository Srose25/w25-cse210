public class Menu()
{
    //Attributes

    int _score;
    List<string> _goalList;


    //Behaviors

    public Menu()
    {
        _goalList = new List<string>{}; //a new empty list
    }

    public void Start()
    {
        bool running = true;

        while(running)
        {
            Console.ReadLine(); //So I don't accidentally make an infi loop
        }
    }

    public void Save()
    {

    }

    public void Load()
    {

    }

    public int UpdateScore() //a method where the score is updated after completing a goal
    {

        return _score;
    }
}