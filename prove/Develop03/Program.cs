using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");



        Word test1 = new Word("TEST!");


        Console.WriteLine(test1.GetWordText()); //This should say TEST!

        test1.Hide();

        Console.WriteLine(test1.GetWordText()); //This should be underscores

        test1.Reveal();

        Console.WriteLine(test1.GetWordText()); //This should say TEST!
    }
}