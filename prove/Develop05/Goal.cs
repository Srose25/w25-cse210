public abstract class Goal
{

    //Attributes

    protected string _goal;
    protected string _gtype;
    protected int _points;
    protected int _score;


    //Behaviors
    public Goal(){}

    public abstract void Display();
    public abstract void RecordEvent();
    public abstract void RecordGoal();


}