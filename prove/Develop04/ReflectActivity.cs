public class ReflectActivity : Activity 
{
    //Attributes
    private List<string> promptList; 

    private List<string> questions;

    //Behaviors

    public ReflectActivity(string title, string desc)

    {
        this._title = title;
        this._desc = desc;

        promptList = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you were in need and someone helped you.",
            "Think of a time where you really felt at peace.",

        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did the experience change you?",
            "What made this experience stand out among the rest?",
            "What is your favorite thing about this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }

    public void DoReflect()
    {
        Console.Clear();
        Console.WriteLine($"{_title}\n");
        Thread.Sleep(2000);
        Console.WriteLine($"{_desc}");

        int time = Clock();

        Console.Clear();
        Random rand = new Random();
        string prompt = promptList[rand.Next(promptList.Count)];

        Console.WriteLine("Consider the Following Prompt: \n");
        Console.WriteLine($"---{prompt}---\n");
        Console.WriteLine("Press Enter to Continue:");

        Console.ReadLine();
        Console.WriteLine("Now, reflect on your memory while answering these questions.\n");
        Thread.Sleep(1000);


        int elapse = 0;
        List<int> chosen = new List<int>{};
        while(elapse < time)
        {
            if (chosen.Count >= questions.Count)
            {
                Console.WriteLine("oopsies :)");
                break;
            }
            Random rand1 = new Random();
            int i = 0;
            do
            {
                i = rand1.Next(questions.Count);
            } while(chosen.Contains(i));

            chosen.Add(i);
            Console.WriteLine($"Question: {questions[i]}\n");
            AnimateProgressBar(10000 / 20); // Animation inside loop
            elapse += 10000;
        }
    }


    private void AnimateProgressBar(int step)
    {
        int barLength = 20;
        for (int i = 0; i < barLength; i++)
        {
            
            Console.Write("[");

            for (int z = 0; z < barLength; z++ )
            {
                if (z > i)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.Write("]");
            Thread.Sleep(step);

            Console.Write("\r");
            
        }

    }
}