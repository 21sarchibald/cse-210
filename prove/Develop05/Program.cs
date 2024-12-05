using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

class Program
{
    private static int _menuSelection;
    private static bool _quitProgram = false;
    List<Goal> _goals = new List<Goal>();
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
                Console.WriteLine("hello");
                DisplayMenu(_goalTypeMenu);
                int _goalType = GetMenuSelection();

                if (_goalType == 1)
                {
                    Console.WriteLine("type 1)");
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