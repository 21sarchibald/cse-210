using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

public class Entry {
    private string prompt;
    private string userInput;
    private string date;
    public Entry()
    {
    }
    public Entry(string date, string prompt, string response)
    {
        this.date = date;
        this.prompt = prompt;
        this.userInput = response;
    }    
    public void CreateEntry()
    {
        prompt = GetRandomPrompt();
        userInput = Console.ReadLine();
        date = GetCurrentDate();
    }
    List<string> _prompts = new List<string>() // add more to this list.
    {
        "What was the best part of my day? ",
        "Who was the most interesting person I interacted with today? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What is one thing I did today to work towards a goal I currently have? ",
        "What was one quality I saw in another person today that I want to start developing in myself? ",
        "What did I do to make today a good day? ",
        "What did I accomplish today to help others come unto Christ? ",
        "When did I feel the Spirit of the Lord the strongest today?"
    };

    public string GetDate()
    {
        return date;
    }
    public void SetDate(string date)
    {
        this.date = date;
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();

        int randomIndex = rnd.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine($"> {randomPrompt}");
        return randomPrompt;
    }
    public string GetCurrentDate()
    {
        DateTime date = DateTime.Today;
        return date.ToString("d");
    }
    public override string ToString()
    {
        string outputString;

        outputString = $"{date}#{prompt}#{userInput}";
        
        return outputString;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {prompt}\n{userInput}");
        Console.WriteLine();
    }
}