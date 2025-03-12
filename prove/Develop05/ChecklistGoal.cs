using System.Globalization;

public class ChecklistGoal : Goal
{

    //Attributes
    private int _scount;
    private int _ecount;
    private int _bonus;


    //Behaviors

    public ChecklistGoal(string goal, string desc, int points, int scount, int ecount, int bonus, bool status)
    {
        _goal = goal;
        _gtype = "Checklist Goal";
        _desc = desc;
        _points = points;
        _scount = scount;
        _ecount = ecount;
        _bonus = bonus;
        _status = status;
    }

    public override string Display()
    {
        return $"{_gtype} - {_goal}: {_desc}, {_points}, {_bonus}, {_scount}/{_ecount}";
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
    
    
           if (int.TryParse(number, out _points))
           {
               return _points;
           }
           else
           {
               Console.WriteLine("Invalid input. Please enter a valid number.");
           }
        }
    }

    public int SetBonus() //Set the bonus
    {
        while(true)
        {
            Console.WriteLine($"How much of a bonus do you want for completing all {_ecount}?");
            string number = Console.ReadLine();
            if (int.TryParse(number, out _bonus))
            {
                return _bonus;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }            
        }
    }

    public int SetEndCount() //Set how many times you want to do this goal
    {
        while(true)
        {
            Console.WriteLine("How many times would you like to do this goal until marking it complete?");
            string number = Console.ReadLine();
            if (int.TryParse(number, out _ecount))
            {
                return _ecount;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }            
        }
        
    }

    public override int GetPoints()
    {
        if(_scount == _ecount)
        {
            _points += _bonus;
        }
        return _points;
    }

    public override void RecordEvent()
    {
        _scount += 1;
        if(_scount == _ecount)
        {
            _status = true;
        }
    }

    public override bool GetStatus()
    {
        return _status;
    }
}