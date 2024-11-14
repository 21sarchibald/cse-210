using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // string fileName;
        int menuSelection;
        do
        {
            DisplayMenu();
            menuSelection = GetSelection();
        }
        while (menuSelection != 5);
        
    }

    static void DisplayMenu()
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do? ");
        }

    static int GetSelection()
    {
        int selection = int.Parse(Console.ReadLine());

        if (selection == 1)
        {
            Entry entry = new Entry();
            string prompt = entry.GetRandomPrompt();
            string userInput = Console.ReadLine();
            DateTime currentDate = entry.GetDate();

            // CreateEntry()

        }
        if (selection == 2)
        {
            //DisplayAllEntries();
        }

        return selection;
        
    }

// Uncomment this when you figure out how to write it to a file.
    // static void CreateEntry(date, prompt, userEntry, fileName)
    // {
    //     string saveEntry = "${date}, {prompt}, {userEntry}, {fileName}";
        
    // }

}
