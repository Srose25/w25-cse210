using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        
        //Debug Sounds

        //Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
        //MainMenu test1 = new MainMenu();
        //if (!File.Exists("talk1.wav"))
        //{
        //    Console.WriteLine("File not found!");
        //}
        //else
        //{
        //    bool running = true;
        //    int go = 0;
        //    Console.WriteLine("File found!");
        //    while(running)
        //    {
        //        if(go == 10)
        //        {
        //            running = false;
        //        }
        //        else
        //        {
        //            test1.PlaySound("talk1.wav");
        //            Thread.Sleep(300);
        //            go += 1;
        //        }
        //    }
        //}

        MainMenu gamestart = new MainMenu();
        gamestart.Start();

    }
}