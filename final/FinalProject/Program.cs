using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!\n");
        Console.WriteLine("This game is best experienced with the soundtrack\n I made along side it. If you would like to experience\n that you can choose to debug the sounds down below before starting by selecting 'y'\n");
        Console.Write("Enter y/n: ");
        string choice = Console.ReadLine();

        if (choice == "y")
        {
            bool running = true;
            while(running)
            {
                Console.WriteLine("To get the sounds to work they must be in your current directory. \nMine was in my NET9.0 bin but for you it may be different.\n");
                Console.WriteLine("Your Current Directory: \n" + Directory.GetCurrentDirectory());
                Console.Write("Press Enter to test:");
                Console.ReadLine();


                Area test1 = new Area(0, false, false, false, false, false, false, false, false, false);
                if (!File.Exists("anger.wav"))
                {
                    Console.WriteLine("File not found!");
                    Console.Write("Press Enter to Test again: ");
                    Console.ReadLine();
                }
                else
                {   
                    Console.WriteLine("File found!\n");
                    test1.PlaySound("anger.wav");
                    
                    Console.WriteLine("Do you want to Play the game now? y/n");
                    string begin = Console.ReadLine();

                    if(begin == "y")
                    {
                        MainMenu gamestart = new MainMenu();
                        gamestart.Start();
                        running = false;
                    }
                    else
                    {
                        running = false;
                    }
                }
            }
        }
        else
        {
            MainMenu gamestart2 = new MainMenu();
            gamestart2.Start();
        }
    }
}