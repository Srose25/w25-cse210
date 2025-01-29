using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Entry testentry = new Entry();

        testentry.DisplayPrompt();
        testentry.GetInput();
        Console.WriteLine(testentry.CompileEntry());
    }
}