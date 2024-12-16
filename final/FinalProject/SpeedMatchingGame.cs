using System.Diagnostics.Metrics;

class SpeedMatchingGame : Game
{
    private int _duration;
    private List<Word> _words = [];
    private List<string> _allDefinitions = [];
    private List<string> _selectedDefinitions = [];
    public SpeedMatchingGame(int duration)
    {
        _duration = duration;
        _instructions = $"Welcome to the speed-matching game. This game will last {_duration} seconds.\nType the number of the definition that best matches the listed word.\nGood luck!\n";
    }

    public override void StartGame()
    {
        LoadVerbs();
        LoadDefinitions();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Word word = _words[SelectRandomWord()];
            Console.WriteLine($"\nVocabulary Word: {word.GetVerb()}");
            _selectedDefinitions = [];
            GetRandomDefinitions();
            string correctDefinition = word.GetDefinition();

            _selectedDefinitions[GetRandomDefinitionIndex()] = correctDefinition;
            
            DisplayDefinitions(_selectedDefinitions);
            Console.Write("\nWhich definition matches the vocab word? ");
            int userInputIndex = int.Parse(Console.ReadLine()) - 1;
            string userAnswer = _selectedDefinitions[userInputIndex];
            
            if (CheckAnswer(userAnswer, correctDefinition))
            {
                Console.WriteLine("\nCorrect!");
                _correctAnswers += 1;
            }
            else
            {
                Console.WriteLine("\nIncorrect");
            }
        }
    }
    private int SelectRandomWord()
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _words.Count);
        return randomIndex;
    }
    private void GetRandomDefinitions()
    {
        while (_selectedDefinitions.Count < 4)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, _words.Count);
            _selectedDefinitions.Add(_allDefinitions[randomIndex]);
        } 
    }
    private int GetRandomDefinitionIndex()
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _selectedDefinitions.Count);
        return randomIndex;
    }
    private void DisplayDefinitions(List<string> definitions)
    {
        int count = 1;
        foreach (string definition in definitions)
        {
            Console.WriteLine($"{count}. {definition}");
            count += 1;
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
        
        Console.WriteLine($"\nThanks for playing! You earned {_correctAnswers} points!");
        Console.WriteLine();
    }

    private void LoadVerbs()
    {
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
    }
    private void LoadDefinitions()
    {
        foreach (Word word in _words)
        {
            _allDefinitions.Add(word.GetDefinition());
        }
    }

}