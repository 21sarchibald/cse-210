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

    public string GetTitle()
    {
        return _title;
    }

    public int GetPoints()
    {
        return _points;
    }

    abstract public void Display();
    abstract public void RecordEvent();
    // abstract public void SetComplete();

}