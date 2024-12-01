class ListingActivity: Activity
{
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];
    private int _itemsCount = 0;

    public ListingActivity() 
    {
        _title = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomItem(_prompts)} --- ");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
        Console.WriteLine();
    }

    public void DisplayListing()
    {
        SetEndTime(_duration);
        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _itemsCount += 1;
        }
        Console.WriteLine($"You listed {_itemsCount} items!");
    }
}