class ConjugationQuiz : Quiz
{
    List<Word> _verbs = [];
    List<string> _forms = ["yo", "tu", "usted/el/ella", "nosotros", "vosotros", "usteded/ellos/ellas"];
    List<Word> _selectedWords = [];
    
    public ConjugationQuiz(int numberOfQuestions) : base(numberOfQuestions)
    {
        _numberOfQuestions = numberOfQuestions;
    }
    public override void StartQuiz()
    {
        LoadVerbs();
        SelectRandomWords();
        foreach (Word word in _selectedWords)
        {
            string verb = word.GetVerb();
            int randomFormIndex = SelectRandomForm();
            string conjugatedVerb = word._conjugations[randomFormIndex];
            string wordForm = _forms[randomFormIndex];
            Console.WriteLine($"\nPlease conjugate the verb '{verb}' in the following form: {wordForm}");
            Console.Write("Conjugated verb: ");
            string userInput = Console.ReadLine();
            if (CheckAnswer(userInput, conjugatedVerb))
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
            int randomIndex = rnd.Next(0, _verbs.Count);
            Word newWord = _verbs[randomIndex];
            _selectedWords.Add(newWord);
        }
        return _selectedWords;
    }
    private int SelectRandomForm()
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _selectedWords.Count);
        return randomIndex;
    }

    public override void EndQuiz()
    {
        Console.WriteLine($"\nWell done! You completed the Conjugation Quiz and got {_correctAnswers}/{_numberOfQuestions} correct answers!\n");
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
            _verbs.Add(newWord);
        }
        // return _verbs;
    }
}