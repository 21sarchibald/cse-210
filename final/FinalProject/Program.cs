using System;
using System.ComponentModel;

class Program
{
    private static string _menu = " 1. Learn\n 2. Start Game\n 3. See Progress\n 4. Quit";
    private static int _menuSelection = 0;
    static void Main(string[] args)
    {
        DisplayMenu();
        _menuSelection = int.Parse(Console.ReadLine());



    }
    static void DisplayMenu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine(_menu);
        Console.Write("Please select a menu option: ");
    }

}