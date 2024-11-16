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
                string fileName = GetFileName();

                myJournal.ReadEntriesFromFile(fileName);
            }

            else if (selection == 4)
            {
                string fileName = GetFileName();

                myJournal.WriteToFile(fileName);
            }
        }
        
        while (selection != 5);  
        }
    static void DisplayMenu()
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
        }

    static string GetFileName()
    {
        Console.WriteLine("What is the file name? ");
        return Console.ReadLine();
    }

}
