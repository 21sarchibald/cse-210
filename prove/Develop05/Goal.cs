using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

abstract class Goal 
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _isComplete = false;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    abstract public void Display();
    // abstract public void RecordEvent(string fileName);
    // abstract public void SetComplete();

    // abstract public void ReadGoalsFromFile(string fileName)
    // {
    //     string[] lines = System.IO.File.ReadAllLines(fileName);

    //     foreach (string line in lines)
    //     {
    //         string[] type = line.Split(":");
    //         string[] parts = type[1].Split("#");

    //         string title = parts[0];
    //         string description = parts[1];
    //         string points = parts[2];

    //         Goal goal = new Goal(title, question, points);
    //         _goals.Add(goal);
    //     }
    // }
}