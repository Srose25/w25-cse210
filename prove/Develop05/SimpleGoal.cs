public class SimpleGoal : Goal
{
    //Attributes

    private bool _status;


    //Behaviors
    public SimpleGoal(string goal, int points, int score, bool status)
    {
        _goal = goal;
        _gtype = "Simple Goal";
        _points = points;
        _score = score;
        _status = status;
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