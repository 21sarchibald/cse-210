using System;
using System.ComponentModel;

class Program
{
    private static string _menu = " 1. Learn\n 2. Start Game\n 3. See Progress\n 4. Quit";
    private static int _menuSelection = 0;
    static void Main(string[] args)
    {
        do
        {
            DisplayMenu();
            _menuSelection = int.Parse(Console.ReadLine());

            if (_menuSelection == 1)
            {
                Console.WriteLine("Quiz Options: \n");
                Console.WriteLine("1. Vocabulary Quiz\n2. Conjugation Quiz\n");
                Console.Write("Which type of quiz would you like to start? ");
                int _quizSelection = int.Parse(Console.ReadLine());
                Console.Write("How many questions do you want your quiz to have? ");
                int _quizQuestions = int.Parse(Console.ReadLine());

                if (_quizSelection == 1)
                {
                    Quiz vocabulary = new VocabularyQuiz(_quizQuestions);
                    vocabulary.StartQuiz();
                    vocabulary.EndQuiz();
                }
                else
                {
                    Quiz conjugation = new ConjugationQuiz(_quizQuestions);
                    conjugation.StartQuiz();
                    conjugation.EndQuiz();
                }
            }
            else if (_menuSelection == 2)
            {
                Console.WriteLine("Game Options: ");
                Console.WriteLine(" 1. Fill-in-the-blank\n 2. Speed-matching");
                Console.Write("Which type of game would you like to play? ");
                int _gameSelection = int.Parse(Console.ReadLine());

                if (_gameSelection == 1)
                {
                    Console.Write("How many questions would you like your quiz to be? ");
                    int _numberOfQuestions = int.Parse(Console.ReadLine());
                    FillInTheBlankGame fillBlank = new FillInTheBlankGame(_numberOfQuestions);
                    fillBlank.StartGame();
                    fillBlank.EndGame();
                }
                else 
                {
                    Console.Write("How long (in seconds) would you like your quiz to last? ");
                    int _duration = int.Parse(Console.ReadLine());
                    SpeedMatchingGame speedMatch = new SpeedMatchingGame(_duration);
                    speedMatch.StartGame();
                    speedMatch.EndGame();
                }
            }

            else if (_menuSelection == 3)
            {
                
            }
        }
        
        while (_menuSelection != 4); 
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine(_menu);
        Console.Write("Please select a menu option: ");
    }

}