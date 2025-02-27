public class ReflectActivity : Activity 
{
    //Attributes

    //Behaviors

    public ReflectActivity(string title, string desc)

    {
        this._title = title;
        this._desc = desc;
    }

    public void DoReflect()
    {
        Console.WriteLine($"{_title}\n");
        Thread.Sleep(2000);
        Console.WriteLine($"{_desc}");

        int time = Clock();
    }
}