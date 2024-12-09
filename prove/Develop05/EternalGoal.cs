class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) :base(title, description, points)
    {       
       
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {_title} ({_description})");
    }

    public override string ToString()
    {
        string outputString;

        outputString = $"EternalGoal:{_title}|{_description}|{_points}";
        return outputString;
    }
}