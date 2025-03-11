public class ChecklistGoal : Goal
{

    //Attributes
    private int _status;
    private int _bonus;


    //Behaviors

    public ChecklistGoal(string goal, string desc, int points, int status, int bonus)
    {
        _goal = goal;
        _gtype = "Checklist Goal";
        _desc = desc;
        _points = points;
        _status = status;
        _bonus = bonus;
    }

    public override string Display()
    {
        return $"{_gtype} - {_goal}: {_desc}, {_points}, {_bonus}, {_status}";
    }

    public override void RecordEvent()
    {
        
    }

    public override string RecordGoal()
    {
        Console.WriteLine("What is your new Checklist Goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public override string SetDesc()
    {
        Console.WriteLine($"Write a short description of ({_goal})");
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

    public int SetBonus() //Calculate the bonus
    {
        return _bonus;
    }
}