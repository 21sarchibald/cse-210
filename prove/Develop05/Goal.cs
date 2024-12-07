using System.ComponentModel.DataAnnotations;

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

}