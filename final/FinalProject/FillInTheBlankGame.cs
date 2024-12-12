using System.IO.Enumeration;
using System.Runtime.CompilerServices;

class FillInTheBlankGame : Game
{
    private int _numberOfQuestions;
    List<string> _sentences;
    private int _questionsCompleted = 0;
    public FillInTheBlankGame(int numberOfQuestions)
    {
        _numberOfQuestions = numberOfQuestions;
        _instructions = $"Welcome to the fill-in-the-blank game. This game will have {_numberOfQuestions} questions.\nType the word that belongs in the blank space for each question then press enter.\nGood luck!";
    }
    public override void StartGame()
    {
        while (_questionsCompleted < _numberOfQuestions)
        {
            Console.WriteLine(_instructions);
            LoadSentences();
            _questionsCompleted = 5;

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

            Sentence newSentence = new Sentence(meaning, wordToRemove);
            sentenceList.Add(newSentence);
            Console.WriteLine(sentence);
        }
        return sentenceList;
    }
    // private Sentence SelectRandomSentence()
    // {
        
    // }
    
    private string RemoveWord()
    {
        return "removedWord"; // FIX THIS.
    }
    public void DisplayBlankSentence()
    {

    }
    public override void CheckAnswer()
    {
        Console.WriteLine("Not finished");
    }

    public override void EndGame()
    {
        Console.WriteLine("Not finished");
    }

}