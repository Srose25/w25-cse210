public class GrassArea : Area
{
    public GrassArea(int depression, bool shovel, bool fishpole, bool rock, bool locket, bool picture, bool musbox, bool Gkey, bool Rkey, bool Ckey)
        : base(depression, shovel, fishpole, rock, locket, picture, musbox, Gkey, Rkey, Ckey)
    {}
        public void GrassStart()
    {
        Console.Clear();
        PlaySound("the_grass.wav");
        PrintResponse("describe_grass");
        bool running = true;

        while(running)
        {
            Console.WriteLine("1. The Tree House");
            Console.WriteLine("2. The Locket");
            Console.WriteLine("3. The Hill");
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
                PrintResponse("grass_hint");
                break;
            }
        }
    }
}