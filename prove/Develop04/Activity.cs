using System.Timers;

public class Activity
{
    //Attributes
    protected string _title;
    protected string _desc;

    //Behaviors

    public Activity()
    {}

    public void Welcome()
    {
        Console.WriteLine("Welcome to the Meditations app: Please pick an option");
        Thread.Sleep(1000);

        Console.Clear();
        userInput();
    }

    public void userInput()
    {
        bool running = true;

        while(running)
        {
            Console.WriteLine(); //White Space
            Console.WriteLine("1. Breathe Activity");
            Console.WriteLine("2. Reflect Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. quit");

            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                BreatheActivity ba1 = new BreatheActivity("Breathing Activity", "\nFirst you will choose how long the duration of the activity will be \nand then you will breathe in and out in 5 second increments.\nTry to only focus on that breath during the activity.");
                ba1.DoBreathe();
                break;

                case "2":
                ReflectActivity ra1 = new ReflectActivity("Reflect Activity", "\nFirst you will choose how long the duration of the activity will be, \nthen you will be given a prompt and as the activity goes on you will reflect on that prompt and on your life.");
                ra1.DoReflect();
                break;

                case "3":
                ListingActivity la1 = new ListingActivity("Listing Activity", "\nFirst you will choose how long the duration of the activity will be, \nthen you will be given a prompt and as the activity goes on you will list the things you can think of relating to the prompt.");
                la1.DoListing();
                break;

                case "4":
                Console.WriteLine("Drink lots of water and get a good nights sleep!");
                running = false;
                break;

                default:
                Console.WriteLine("Invalid Option: Choose another.");
                break;

            }

        }
    }

    public void StartMessage(string title, string desc)
    {
        Console.Clear();
        Console.WriteLine($"Hello! Welcome to the {title}!");
        Thread.Sleep(2000);
        Console.WriteLine($"\n{desc}");
    }

public int Clock()
{
    int time;
    
    while (true)
    {
        Console.WriteLine("\nHow many intervals (1 interval = 10 seconds) would you like to do this activity?");
        string tinput = Console.ReadLine();

        if (int.TryParse(tinput, out time) && time > 0)
        {
            Console.WriteLine($"You will do this activity for {time * 10} seconds");
            Thread.Sleep(3000);
            
            Console.Clear();
            Console.WriteLine("Activity Starting Soon... Get Ready!");
            AnimateProgressBar(3000 / 20);


            return time * 10 * 1000; //interval * seconds * milliseconds
        }
        
        Console.WriteLine("Invalid option. Please enter a positive number.");
    }
}


    public void AnimateProgressBar(int step)
    {
        int barLength = 20;
        for (int i = 0; i < barLength; i++)
        {
            Console.Write("[");

            for (int z = 0; z < barLength; z++ )
            {
                if (z > i)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.Write("]");
            Thread.Sleep(step);

            Console.Write("\r");
        }
    }

    public void EndMessage(string title)
    {
        Console.WriteLine($"Thank you, I hope you found the {title} enlightening or at all helpful!");

        Thread.Sleep(5000);

        Console.Clear();
    }
}