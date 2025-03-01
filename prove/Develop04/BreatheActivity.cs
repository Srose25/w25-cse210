public class BreatheActivity : Activity 
{

    public BreatheActivity(string title, string desc)

    {
        this._title = title;
        this._desc = desc;
    }

    public void DoBreathe()
    {
        StartMessage(_title, _desc);
        int time = Clock();

        Console.Clear();
        int elapse = 0;

        while (elapse < time)
        {
            Console.WriteLine($"Breathe in...");
            AnimateProgressBar(5000 / 20);

            Console.WriteLine();
            
            Console.WriteLine($"Breathe Out...");
            AnimateProgressBar(5000 / 20);

            Console.WriteLine();
            elapse += 10000;
        }
    }
}