public abstract class Goal
{

    //Attributes

    protected string _goal;
    protected string _gtype;
    protected string _desc;
    protected int _points;


    //Behaviors
    public Goal(){}

    public abstract string Display();
    public abstract void RecordEvent();
    public abstract string RecordGoal();
    public abstract string SetDesc();
    public abstract int SetPoints();


}