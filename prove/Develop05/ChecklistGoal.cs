class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _checklistNumber;
    private int _timesCompleted = 0;
    public ChecklistGoal(int bonusPoints, int checklistNumber, string title, string description, int points) :base(title, description, points)
    {
        _bonusPoints = bonusPoints;
        _checklistNumber = checklistNumber;
    }

    public override void Display()
    {
        if (!_isComplete)
            Console.WriteLine($"[ ] {_title} ({_description}) -- Currently completed: {_timesCompleted}/{_checklistNumber}");
        else
            Console.WriteLine($"[X] {_title} {_description}) -- Currently completed: {_timesCompleted}/{_checklistNumber}");
    }

    public override string ToString()
    {
        string outputString;

        outputString = $"ChecklistGoal:{_title}|{_description}|{_points}|{_bonusPoints}|{_checklistNumber}|{_timesCompleted}|{_isComplete}";
        return outputString;
    }
}