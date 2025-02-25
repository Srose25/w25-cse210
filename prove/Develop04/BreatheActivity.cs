public class BreatheActivity : Activity 
{

    public BreatheActivity(string title, string desc)
     : base(title, desc)
    {
        this._title = title;
        this._desc = desc;
    }

    public void DoBreathe()
    {
        Console.WriteLine($"{_title}\n");
        Console.WriteLine($"{_desc}");

        

    }
}