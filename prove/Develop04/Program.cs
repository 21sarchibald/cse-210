using System;

class Program
{
    private static int _menuSelection;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        DisplayMenu();
        _menuSelection = GetMenuSelection();

        if (_menuSelection == 1)
        {
            BreathingActivity breathing = new BreathingActivity();
            breathing.Display();
            breathing.SetDuration(GetDuration());
            breathing.DisplayStart();
            breathing.DisplayBreathing();
            breathing.DisplayEndMessage();
        }
        else if (_menuSelection == 2)
        {
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.Display();
            reflection.SetDuration(GetDuration());
            reflection.DisplayStart();
            reflection.DisplayPrompt();
            reflection.DisplayReflection();
            reflection.DisplayEndMessage();
        }
        else if (_menuSelection == 3)
        {
            ListingActivity listing = new ListingActivity();
            listing.Display();
            listing.SetDuration(GetDuration());
        }
        else
        {
            // Quit
        }

    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    private static int GetMenuSelection() 
    {
        int menuSelection = int.Parse(Console.ReadLine());
        return menuSelection;
    }

    private static int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        return int.Parse(Console.ReadLine());
    }

}