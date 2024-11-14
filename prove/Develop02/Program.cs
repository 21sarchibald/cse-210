using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        int selection = 0;
        Journal myJournal = new Journal();
        do
        {
            DisplayMenu();
            selection = int.Parse(Console.ReadLine());
            if (selection == 1)
        {
            Entry entry = new Entry();
            entry.CreateEntry();
    
            
            myJournal.AddEntry(entry);

        }
        else if (selection == 2)
        {
            myJournal.DisplayAllEntries();
        }

        else if (selection == 3)
        {
            // Obtain file name and read from file
        }

        else if (selection == 4)
        {
            //Obtain file name and write to file
        }
        }
        while (selection != 5);  
    }
    static void DisplayMenu()
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
        }

// Uncomment this when you figure out how to write it to a file.
    // static void CreateEntry(date, prompt, response, fileName)
    // {
    //     string saveEntry = "${date}, {prompt}, {response}, {fileName}";
        
    // }

}
