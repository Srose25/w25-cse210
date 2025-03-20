public class MainMenu()
{
    //Attributes

    //Behaviors
    public void Start()
    {
        bool running = true;

        while(running)
        {
            Console.Clear();
            Console.WriteLine("The Box");
            Console.WriteLine("1. Play"); //What kinds of settings can I add?
            Console.WriteLine("2. Quit");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":

                break;


                case "2":
                running = false;
                break;
            }
        }
    }

}