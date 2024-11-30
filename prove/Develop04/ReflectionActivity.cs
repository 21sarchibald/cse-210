using System.Reflection;

class ReflectionActivity: Activity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."];
    private List<string> _reflectQuestions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"];
    public ReflectionActivity()
    {
        _title = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        // _duration = duration;
    }

    private string GetRandomItem(List<string> list)
    {
        Random rnd = new Random();
        int random = rnd.Next(0, list.Count);
        string randomItem = list[random];
        return randomItem;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomItem(_prompts)} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
    }
    public void DisplayReflection()
    {
        Console.Clear();
        SetEndTime(_duration);

        while (DateTime.Now < _endTime)
        {
            Console.WriteLine();
            Console.Write($"> {GetRandomItem(_reflectQuestions)} ");
            DisplayCountdown(5);
        }
        Console.WriteLine();
    }
}