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
            string _menu = "Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit\nSelect a choice from the menu: ";
            DisplayMenu(_menu);
            _menuSelection = GetMenuSelection();

            if (_menuSelection == 1)
            {
                Console.WriteLine("hello");
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