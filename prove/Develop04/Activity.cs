using System.Reflection;

class Activity
{
    protected string _title;
    protected string _description;
    protected int _duration;
    protected DateTime _currentTime = DateTime.Now;
    protected DateTime _endTime;
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
        _endTime = _currentTime.AddSeconds(_duration);
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

    public void DisplayStart()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        DisplayCountdown(5);
        Console.WriteLine();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");

        DisplayCountdown(5);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_title}.");
    }

    public void DisplayCountdown(int countDown)
    {
        for (int i = countDown; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}