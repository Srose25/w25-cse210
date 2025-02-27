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
        Thread.Sleep(2000);
        Console.WriteLine($"{_desc}");

        int time = Clock();

        Console.Clear();
        int elapse = 0;

        while (elapse < time)
        {
            Console.Write($"Breathe in...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i}");

                Thread.Sleep(1000); // Pause for animation effect
                Console.Write("\b \b");
                elapse += 1000;
            }
            Console.WriteLine();
            
            Console.Write($"Breathe Out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i}");

                Thread.Sleep(1000);
                Console.Write("\b \b");
                elapse += 1000;
            }
            Console.WriteLine();
        }

        

    }
}