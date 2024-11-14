using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

public class Entry {
    private string prompt;
    private string userInput;
    private string date;
    public Entry()
    {
        prompt = "";
        userInput = "";
        date = "";
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
        "If I had one thing I could do over today, what would it be? "
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
        Console.WriteLine(randomPrompt);
        return randomPrompt;
    }


    public string GetCurrentDate()
    {
        DateTime date = DateTime.Today;
        return date.ToString();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {prompt}\n{userInput}");
    }
}