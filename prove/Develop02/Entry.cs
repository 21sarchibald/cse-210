using System.Security.Cryptography.X509Certificates;

public class Entry {

    
    List<string> _prompts = new List<string>() // add more to this list.
    {
        "What was the best part of my day? ",
        "Who was the most interesting person I interacted with today? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? "
    };
    
    public string GetRandomPrompt()
    {
        Random rnd = new Random();

        int randomIndex = rnd.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine(randomPrompt);
        return randomPrompt;
    }


    public DateTime GetDate()
    {
        DateTime date = DateTime.Today;
        return date;
    }
}