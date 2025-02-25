public class Activity
{
    //Attributes
    protected string _title;
    protected string _desc;

    //Behaviors

    public Activity(string title, string desc)
    {
        _title = title;
        _desc = desc;
    }
    public void Welcome()
    {
        Console.WriteLine("Welcome to the Meditations app: Pick an option below \n");
    }

    public void userInput()
    {
        bool running = true;

        while(running)
        {
            Console.WriteLine("1. Breathe Activity");
            Console.WriteLine("2. Reflect Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. quit");

            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                BreatheActivity ba1 = new BreatheActivity("Breathing Activity", "Welcome to the Breathing Activity! First you will choose how long the duration of the activity will be and then you will breathe in and out in 5 second increments. Try to only focus on that breath during the activity.");
                ba1.DoBreathe();
                break;

                case "2":
                ReflectActivity ra1 = new ReflectActivity("Reflect Activity", "Welcome to the Reflect Activity! First you will choose how long the duration of the activity will be, then you will be given a prompt and as the activity goes on you will reflect on that prompt and on your life.");
                ra1.DoReflect();
                break;

                case "3":
                ListingActivity la1 = new ListingActivity("Listing Activity", "Welcome to the Listing Activity! First you will choose how long the duration of the activity will be, then you will be given a prompt and as the activity goes on you will list the things you can think of relating to the prompt.");
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

    public void Clock()
    {
        Console.WriteLine("How long (in seconds) would you like to do this activity?");
        string tinput = Console.ReadLine();

        if (int.TryParse(tinput, out int time))
        {
            Console.WriteLine($"You will do this activity for {time} seconds");
        }

        else
        {
            Console.WriteLine("Invalid Option. Please choose a number");
        }


        Console.Clear();
        Console.Write("Activity Starting in...");
        Thread.Sleep(500);
        Console.Write("3...");
        Thread.Sleep(1000);
        Console.Write("2...");
        Thread.Sleep(1000);
        Console.Write("1...");
        Thread.Sleep(1000);


        //create the timer
        time = time * 1000;

        Thread.Sleep(time);

        //create the animation
    }




}