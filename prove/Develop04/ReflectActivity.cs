public class ReflectActivity : Activity 
{
    //Attributes

    //Behaviors

    public ReflectActivity(string title, string desc)
        : base(title, desc)
    {
        this._title = title;
        this._desc = desc;
    }

    public void DoReflect()
    {
        Console.WriteLine($"{_title}\n");
        Console.WriteLine($"{_desc}");
    }
}