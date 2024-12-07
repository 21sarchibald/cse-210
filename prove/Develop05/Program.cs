using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

class Program
{
    private static int _menuSelection;
    private static bool _quitProgram = false;
    protected static List<Goal> _goals = new List<Goal>();
    static void Main(string[] args)
    {
        do
        {
            string _mainMenu = "Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit\nSelect a choice from the menu: ";
            string _goalTypeMenu = "The types of Goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nWhich type of goal would you like to create? ";
            DisplayMenu(_mainMenu);
            _menuSelection = GetMenuSelection();

            if (_menuSelection == 1)
            {
                DisplayMenu(_goalTypeMenu);
                int _goalType = GetMenuSelection();

                if (_goalType == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string title = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    
                    Goal goal = new SimpleGoal(title, description, points);
                    _goals.Add(goal);

                }
                if (_goalType == 2)
                {
                    
                }
                if (_goalType == 3)
                {

                }

            }
            else if (_menuSelection == 2)
            {
                int goalCount = 0;
                foreach (Goal listGoal in _goals)
                {
                    goalCount += 1;
                    Console.Write($"{goalCount}. ");
                    listGoal.Display();
                }
            }
            else if (_menuSelection == 3)
            {
                
            }
            else
            {
                _quitProgram = true;
            }
        }
            while (_quitProgram == false);

    }

    static void DisplayMenu(string menu)
    {
        Console.Write(menu);
    }

    static int GetMenuSelection()
    {
        return int.Parse(Console.ReadLine());
    }
}