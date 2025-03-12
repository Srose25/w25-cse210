public class Menu()
{
    //Attributes

    int _score = 0;
    List<Goal> _goalList = new List<Goal>{};
    List<string> _milestones = new List<string> //A list full of encouraging milestone messages
    {

    };


    //Behaviors
    public void Start()
    {
        bool running = true;

        while(running)
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Goal Setting App!");
            Milestone();
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();



            switch(choice)
            {
            case "1":
            int gchoice = SelectGoalType();
            Console.Clear();
            if (gchoice == 1)
            {
                SimpleGoal sgoal1 = new SimpleGoal("goal", "desc", 0, false );
                AnimateProgressBar(1000 / 10);
                Console.WriteLine("Simple Goal: \n");

                sgoal1.RecordGoal();
                sgoal1.SetDesc();
                sgoal1.SetPoints();
                _goalList.Add(sgoal1);
                AnimateProgressBar(1000 / 10);
            }

            else if (gchoice == 2)
            {
                EternalGoal egoal1 = new EternalGoal("goal", "desc", 0, false);
                AnimateProgressBar(1000 / 10);
                Console.WriteLine("Eternal Goal: \n");
                
                egoal1.RecordGoal();
                egoal1.SetDesc();
                egoal1.SetPoints();
                _goalList.Add(egoal1);
                AnimateProgressBar(1000 / 10);
            }

            else if (gchoice == 3)
            {
                ChecklistGoal cgoal1 = new ChecklistGoal("goal", "desc", 0, 0, 0, 0, false);
                AnimateProgressBar(1000 / 10);
                Console.WriteLine("Checklist Goal: \n");

                cgoal1.RecordGoal();
                cgoal1.SetDesc();
                cgoal1.SetPoints();
                cgoal1.SetEndCount();
                cgoal1.SetBonus();
                _goalList.Add(cgoal1);
                AnimateProgressBar(1000 / 10);
            }

            else
            {
                Console.WriteLine("Error");
                AnimateProgressBar(1000 / 10);
            }
            break;

            case "2":
            Console.Clear();
            for (int i = 0; i < _goalList.Count; i++)
            {
                if (_goalList[i].GetStatus() == true)
                {
                    Console.WriteLine($"{i + 1}. [X] {_goalList[i].Display()}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. [ ] {_goalList[i].Display()}");                    
                }

            }
            Console.WriteLine("Press enter to go back to menu");
            Console.ReadLine();
            break;

            case "3":
            Save();
            break;

            case "4":
            Load();
            break;

            case "5":
            RecordGoalEvent();
            break;
            }
        }
    }

    public int SelectGoalType()//This menu asks the player which type of goal they want to create
    {
        bool running = true;

        while(running)
        {
            Console.Clear();
            Console.WriteLine("What kind of goal do you want to set? \n");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                return 1;

                case "2":
                return 2;

                case "3":
                return 3;

                default: 
                running = false;
                break;
            }
        }
        return 0;
    }

public void RecordGoalEvent()
{
    Console.WriteLine("Select a goal to record:");
    for (int i = 0; i < _goalList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goalList[i].Display()}");
    }

    if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goalList.Count)
    {
        Goal selectedGoal = _goalList[choice - 1];
        selectedGoal.RecordEvent();

        _score += selectedGoal.GetPoints();
    }
    else
    {
        Console.WriteLine("Invalid selection.");
    }
}


    public void Save()
    {

    }

    public void Load()
    {

    }

        public void AnimateProgressBar(int step)
    {
        //quite a bit of logic that helps animate the progress bar
        int barLength = 10;
        //[i] works as a clock of sorts making sure that each interval is stepping forward
        for (int i = 0; i < barLength; i++)
        {
            Console.Write("[");

            //[z] works to print out the entire progress bar with the right amount of - / # so that you can see the end of the progress bar
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

    public void Milestone() // A method that will print a new piece of text whenever the user reaches a milestone... this will be long
    {

    }
}