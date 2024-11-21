using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        Word word = new Word();

        reference.SetReference("John 3:16");
        scripture.SetScripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        scripture.SplitScripture();

        
        // string word1 = scripture.SelectRandomWord();
        // string word2 = scripture.SelectRandomWord();
        // string word3 = scripture.SelectRandomWord();

        bool quitProgram = false;

        do
        {
            reference.DisplayReference();
            scripture.Display();
            scripture.HideWords();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                quitProgram = true;
            }
        }
            while (quitProgram == false);
        

    }
}