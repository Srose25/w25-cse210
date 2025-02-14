public class Menu
{

    //Attributes
    private int _difficulty;

    private List<Verse> _scripture;

    //Initialize
    public Menu()
    {
        _scripture = new List<Verse>()
        {
            new Verse("And it came to pass", new Reference("Joe", 5, 6, 12)),

        };

    }
    //Behaviors

    public void MenuLoop()
    {

        Console.WriteLine("Pick a Verse\n");
        for(int i = 0; i < _scripture.Count; i ++)
        {
            Console.WriteLine($"{i + 1}. {_scripture[i].GetReference()}");
        }

        //get user input for the verse


        //switch case and menu loop
        
         

//        Console.WriteLine("Quit");
//
//
//        string userInput = Console.ReadLine();
//        while (userInput != "quit")
//        {
//            switch (userInput)
//            {
//                case "1":
//
//                break;  
//            }
//
//
//
//
//        }

    }
}