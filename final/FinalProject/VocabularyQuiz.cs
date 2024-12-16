using System.Reflection;
using System.Reflection.Metadata;

class VocabularyQuiz : Quiz
{
    List<Word> _selectedWords = [];
    List<Word> _words = [];
    public VocabularyQuiz(int numberOfQuestions) : base(numberOfQuestions)
    {
        _numberOfQuestions = numberOfQuestions;
    }

    public override void StartQuiz()
    {
        LoadVerbs();
        SelectRandomWords();
        Console.WriteLine("\nPlease type the Spanish vocabulary word that matches the corresponding definition:");
        foreach (Word word in _selectedWords)
        {
            string definition = word.GetDefinition();
            Console.WriteLine($"\nDefinition: {definition}");
            Console.Write("Corresponding vocabulary word: ");
            string userInput = Console.ReadLine();
            if (CheckAnswer(userInput, word.GetVerb()))
            {
                Console.WriteLine("Correct!");
                _correctAnswers += 1;
                word.SetLearned();
            }
            else
            {
                Console.WriteLine("Incorrect");
                word.SetNotLearned();
            }
        }
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

    public override List<Word> SelectRandomWords()
    {
        while (_selectedWords.Count < _numberOfQuestions)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, _words.Count);
            Word newWord = _words[randomIndex];
            _selectedWords.Add(newWord);
        }
        return _selectedWords;
    }
    public void DisplayDefinition(Word word)
    {
        Console.Write(word.GetDefinition());
    }
    public override void EndQuiz()
    {
        Console.WriteLine($"Well done! You completed the Vocabulary Quiz and got {_correctAnswers}/{_numberOfQuestions} correct answers!");
    }

    public override void LoadVerbs()
    {
         // _verbs = [];
        string[] lines = System.IO.File.ReadAllLines("verbs.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string verb = parts[0];
            string definition = parts[2];
            string conjugations = parts[3];
            string[] conjugationList = conjugations.Split(",");
            bool isIrregular = bool.Parse(parts[4]);
            bool isLearned = bool.Parse(parts[5]);
            // Console.WriteLine($"{verb}, {definition}, {conjugations}, {conjugationList} {isIrregular}, {isLearned}");

            Word newWord = new Word(verb, definition, conjugationList, isIrregular, isLearned);
            // Console.WriteLine(newWord);
            _words.Add(newWord);
        }
        // return _verbs;
    }
}