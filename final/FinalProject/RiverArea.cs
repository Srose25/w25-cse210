using System.Xml.Serialization;

public class RiverArea : Area
{
    public RiverArea(int depression, bool shovel, bool fishpole, bool rock, int locket, int picture, int musbox, bool Gkey, bool Rkey, bool Ckey)
        : base(depression, shovel, fishpole, rock, locket, picture, musbox, Gkey, Rkey, Ckey)
    {}
        public void RiverStart()
    {
        Console.Clear();
        PrintResponse("describe_river");
        bool running = true;

        while(running)
        {
            Console.WriteLine("1. Go fishing");
            Console.WriteLine("2. The Little Boat");
            Console.WriteLine("3. Mound of Dirt");
            Console.WriteLine("4. Go Back");
            Console.WriteLine("5. Hint");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                if (_fishpole == true)
                {

                }
                else
                {

                }
                break;

                case "2":
                if (_shovel == true)
                {

                }
                else
                {

                }
                break;

                case "3":
                if(_rock == true)
                {

                }
                else
                {

                }
                break;

                case "4":
                running = false;
                break;

                case "5":
                PrintResponse("river_hint");
                break;
            }
        }
    }
}