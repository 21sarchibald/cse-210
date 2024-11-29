using System.Reflection;

class Activity
{
    protected string _title;
    protected string _description;
    protected int _duration;
    protected string _endMessage;

    public Activity()
    {

    }


    // public void SetTitle(string title)
    // {
    //     _title = title;
    // }

    // public void SetDescription(string description)
    // {
    //     _description = description;
    // }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
    // public void SetEndMessage(string endMessage)
    // {
    //     _endMessage = endMessage;
    // }

    public void Display()
    {
        Console.WriteLine($"Welcome to the {_title}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

}