public class CaveArea : Area 
{
    public CaveArea(int depression, bool shovel, bool fishpole, bool rock, bool locket, bool picture, bool musbox, bool Gkey, bool Rkey, bool Ckey)
        : base(depression, shovel, fishpole, rock, locket, picture, musbox, Gkey, Rkey, Ckey)
    {}
    public void CaveStart()
    {
        Console.Clear();
        PlaySound("the_cave.wav");
        PrintResponse("describe_cave");
        bool running = true;

        while(running)
        {

            Console.WriteLine("1. Bottomless Pit");
            Console.WriteLine("2. Dig a Rock");
            Console.WriteLine("3. Memorial");
            Console.WriteLine("4. Go Back");
            Console.WriteLine("5. Hint");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                break;

                case "2":
                break;

                case "3":
                break;

                case "4":
                running = false;
                break;

                case "5":
                PrintResponse("cave_hint");
                break;
            }
        }
    }
}