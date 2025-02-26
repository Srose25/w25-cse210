public class BreatheActivity : Activity 
{

    public BreatheActivity(string title, string desc)

    {
        this._title = title;
        this._desc = desc;
    }

    public void DoBreathe()
    {
        Console.WriteLine($"{_title}\n");
        Console.WriteLine($"{_desc}");

        int time = Clock();

        Console.Clear();

        

        

    }
}