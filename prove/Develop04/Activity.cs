using System.Reflection;

class Activity
{
    protected string _title;
    protected string _description;
    protected int _duration;
    protected DateTime _currentTime;
    protected DateTime _endTime;

    public Activity()
    {
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void SetEndTime(int duration)
    {
        _currentTime = DateTime.Now;
        _endTime = _currentTime.AddSeconds(duration);
    }

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
        DisplayCountdown(5);
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

    protected string GetRandomItem(List<string> list)
    {
        Random rnd = new Random();
        int random = rnd.Next(0, list.Count);
        string randomItem = list[random];
        return randomItem;
    }

}