using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());


        MainMenu test1 = new MainMenu();
        if (!File.Exists("sfx1.wav"))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            Console.WriteLine("File found!");
            test1.PlaySound("sfx1.wav");
            Thread.Sleep(1000);
            test1.PlaySound("sfx1.wav");
            Thread.Sleep(5000);
        }

    }
}