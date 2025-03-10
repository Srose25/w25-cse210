public class ChecklistGoal : Goal
{

    //Attributes
    private int _status;
    private int _bonus;


    //Behaviors

    public ChecklistGoal(string goal, int points, int score, int status, int bonus)
    {
        _goal = goal;
        _gtype = "Checklist Goal";
        _points = points;
        _score = score;
        _status = status;
        _bonus = bonus;
    }

    public override void Display()
    {

    }

    public override void RecordEvent()
    {
        
    }

    public override void RecordGoal()
    {
        
    }
}