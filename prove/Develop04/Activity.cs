public class Activity
{
    //Attributes
    private string _title;
    private string _desc;
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
        while(true)
        {
            Console.WriteLine("1. Breathe Activity");
            Console.WriteLine("2. Reflect Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. quit");

            Console.ReadLine();



        }
    }

    public void Clock()
    {
        //have the user input how many seconds

        //create the timer

        //create the animation
    }




}