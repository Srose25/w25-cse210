public class EternalGoal : Goal
{

    //Attributes

    //Behaviors

    public EternalGoal(string goal, string desc, int points)
    {
        _goal = goal;
        _gtype = "Eternal Goal";
        _desc = desc;
        _points = points;
    }

    public override string Display()
    {
        return $"{_gtype} - {_goal}: {_desc}, {_points}";
    }

    public override void RecordEvent()
    {

    }

    public override string RecordGoal()
    {
        Console.WriteLine("What is your new Eternal Goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public override string SetDesc()
    {
        Console.WriteLine($"Write a short description of {_goal}");
        _desc = Console.ReadLine();
        return _desc;
    }

    public override int SetPoints()
    {
        while(true)
        {
           Console.WriteLine("How many points should this be worth?");
           string number = Console.ReadLine();
    
    
           if (int.TryParse(number, out int _points))
           {
               return _points;
           }
           else
           {
               Console.WriteLine("Invalid input. Please enter a valid number.");
           }
        }
    }
}