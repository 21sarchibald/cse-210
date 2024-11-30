using System.Diagnostics;

class BreathingActivity: Activity
{
    private string _breathIn;
    private string _breathOut;

    public BreathingActivity()
    {
        _title = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void DisplayBreathing()
    {
        SetEndTime(_duration);
        while (DateTime.Now < _endTime)
        {
            Console.Write("Breathe in...");
            DisplayCountdown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            DisplayCountdown(8);
            Console.WriteLine();
        }
    }
}
