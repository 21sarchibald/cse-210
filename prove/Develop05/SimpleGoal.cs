using System.ComponentModel;
using System.Reflection;

class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points, bool isComplete = false) :base(title, description, points)
    {

    }

    public override void Display()
    {
        if (!_isComplete)
            Console.WriteLine($"[ ] {_title} ({_description})");
        else
            Console.WriteLine($"[X] {_title} ({_description})");
    }

    public override string ToString()
    {
        string outputString;

        outputString = $"SimpleGoal:{_title}|{_description}|{_points}|{_isComplete}";
        return outputString;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
}