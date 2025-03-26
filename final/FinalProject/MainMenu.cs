using System.Formats.Asn1;
using System.Media;
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
                Area start = new Area(0, 0, false, false, false);
                start.Start();
                break;


                case "2":
                running = false;
                break;
            }
        }
    }
    public void PlaySound(string key)
    {
        try
        {
            SoundPlayer player = new SoundPlayer(key);
            player.Play();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to play sound: {ex.Message}");
        }
    }
}