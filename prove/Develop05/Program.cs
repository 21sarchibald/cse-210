using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

class Program
{
    private static int _menuSelection;
    private static bool _quitProgram = false;
    private static int _totalPoints = 0;
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
                    
                    Goal simpleGoal = new SimpleGoal(title, description, points);
                    _goals.Add(simpleGoal);

                }
                if (_goalType == 2)
                {
                    Console.Write("What is the name of your goal? ");
                    string title = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    Goal eternalGoal = new EternalGoal(title, description, points);
                    _goals.Add(eternalGoal);
                }
                if (_goalType == 3)
                {
                    Console.Write("What is the name of your goal? ");
                    string title = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int checklistNumber = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    Goal checklistGoal = new ChecklistGoal(title, description, points, bonusPoints, checklistNumber);
                    _goals.Add(checklistGoal);
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
                // Console.WriteLine();
                // Console.WriteLine($"You have {_totalPoints} points.");
                // Console.WriteLine();
            }
            else if (_menuSelection == 3)
            {
                Console.Write("What is the name for the goal file? ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName)) 
                {
                    outputFile.WriteLine(_totalPoints);
                    
                    foreach (Goal goal in _goals)
                    {
                        outputFile.WriteLine(goal.ToString());
                    }
                }
            }
            else if (_menuSelection == 4)
            {
                Console.Write("What is the file name for the goal file? ");
                string fileName = Console.ReadLine();
                // ReadGoalsFromFile(fileName);
                string[] lines = System.IO.File.ReadAllLines(fileName);
                lines = lines.Skip(1).ToArray();
                foreach (string line in lines)
                {
                    string[] type = line.Split(":");

                    if (type[0] == "SimpleGoal")
                    {
                        string[] parts = type[1].Split("|");

                        string title = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        bool isComplete = bool.Parse(parts[3]);

                        Goal simpleGoal = new SimpleGoal(title, description, points, isComplete);
                        _goals.Add(simpleGoal);
                    }
                    else if (type[0] == "EternalGoal")
                    {
                        string[] parts = type[1].Split("|");

                        string title = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);

                        Goal eternalGoal = new EternalGoal(title, description, points);
                        _goals.Add(eternalGoal);
                    }
                    else if (type[0] == "ChecklistGoal")
                    {
                        string[] parts = type[1].Split("|");

                        string title = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        int bonusPoints = int.Parse(parts[3]);
                        int checklistNumber = int.Parse(parts[4]);


                        Goal checklistGoal = new ChecklistGoal(title, description, points, bonusPoints, checklistNumber);
                        _goals.Add(checklistGoal);
                    }
                }

            }
            else
            {
                _quitProgram = true;
            }
            Console.WriteLine();
            Console.WriteLine($"You have {_totalPoints} points.");
            Console.WriteLine();
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