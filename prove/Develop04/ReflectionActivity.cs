using System.Reflection;

class ReflectionActivity: Activity
{
    private List<string> _prompts;
    private List<string> _reflectQuestions;
    public ReflectionActivity()
    {
        _title = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        // _duration = duration;
    }
}