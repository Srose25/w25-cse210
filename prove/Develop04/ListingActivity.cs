public class ListingActivity : Activity 
{
    //Attributes

    //Behaviors

    public ListingActivity(string title, string desc)

    {
        this._title = title;
        this._desc = desc;
    }

    public void DoListing()
    {
        Console.WriteLine($"{_title}\n");
        Console.WriteLine($"{_desc}");

        int time = Clock();
    }
}