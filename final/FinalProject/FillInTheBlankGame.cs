using System.IO.Enumeration;
using System.Runtime.CompilerServices;

class FillInTheBlankGame : Game
{
    private int _numberOfQuestions;
    private List<Sentence> _sentences;
    private List<Sentence> _selectedSentences = [];
    public FillInTheBlankGame(int numberOfQuestions)
    {
        _numberOfQuestions = numberOfQuestions;
        _instructions = $"Welcome to the fill-in-the-blank game. This game will have {_numberOfQuestions} questions.\nType the word that belongs in the blank space for each question then press enter.\nGood luck!\n";
    }
    public override void StartGame()
    {
            Console.WriteLine(_instructions);
            _sentences = LoadSentences();
            _selectedSentences = SelectRandomSentences(_numberOfQuestions);
            foreach (Sentence sentence in _selectedSentences)
            {
                Console.WriteLine(sentence._meaning);
                string hiddenWord = sentence.RemoveWord();
                sentence._sentenceWords[sentence._wordToRemoveIndex] = hiddenWord;
                
                foreach (string sentenceWord in sentence._sentenceWords)
                {
                    Console.Write($"{sentenceWord} ");
                }
                string userAnswer = Console.ReadLine();
                if (CheckAnswer(userAnswer, sentence._wordToRemove))
                {
                    Console.WriteLine("\nCorrect!");
                    _correctAnswers += 1;
                }
                else 
                {
                    Console.WriteLine("\nIncorrect");
                }
                Console.WriteLine();
            }

    }
    private List<Sentence> LoadSentences()
    {
        List<Sentence> sentenceList = [];
        string fileName = "sentences.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string sentence = parts[0];
            string[] sentenceWords = sentence.Split(" ");
            int wordToRemoveIndex = int.Parse(parts[1]);
            string wordToRemove = sentenceWords[wordToRemoveIndex];
            string meaning = parts[2];

            Sentence newSentence = new Sentence(sentence, sentenceWords, wordToRemove, wordToRemoveIndex, meaning);
            sentenceList.Add(newSentence);
        }
        return sentenceList;
    }
    private List<Sentence> SelectRandomSentences(int numberOfSentences)
    {
        while (_selectedSentences.Count < numberOfSentences)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, _sentences.Count);
            Sentence newSentence = _sentences[randomIndex];
            _selectedSentences.Add(newSentence);
        }
        return _selectedSentences;
    }
    
    public void DisplayBlankSentence()
    {

    }
    public override bool CheckAnswer(string userInput, string correctAnswer)
    {
        if (userInput == correctAnswer)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void EndGame()
    {
        string[] lines = System.IO.File.ReadAllLines("progress.txt");
        int _previousPoints = 0;
        foreach (string line in lines)
        {
            _previousPoints = int.Parse(line);
        }
        int _totalPoints = _correctAnswers + _previousPoints;
        
        using (StreamWriter outputFile = new StreamWriter("progress.txt"))
        {
            outputFile.WriteLine(_totalPoints.ToString());
        }
        
        Console.WriteLine($"Thanks for playing! You earned {_correctAnswers} points!");
        Console.WriteLine();
    }

}