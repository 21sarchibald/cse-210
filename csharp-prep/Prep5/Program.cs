using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string nameInput = Console.ReadLine();
        return nameInput;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int numberInput = int.Parse(Console.ReadLine());
        return numberInput;
    }
    static int SquareNumber()
    {
        int number = PromptUserNumber();
        int numberSquared = number * number;
        return numberSquared;
    }
    static void DisplayResult()
    {
        string name = PromptUserName();
        int numberSquared = SquareNumber();
        Console.WriteLine($"{name}, the square of your number is {numberSquared}");
    }
}