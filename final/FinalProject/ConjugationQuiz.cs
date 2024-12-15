class ConjugationQuiz : Quiz
{
    List<Word> _verbs = [];
    List<string> _forms = ["yo", "tu", "usted/el/ella", "nosotros", "vosotros", "usteded/ellos/ellas"];
    int _numberOfQuestions;
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
            Console.WriteLine($"Please conjugate the verb: {verb} in the following form: {wordForm}");
            Console.Write("Conjugated verb: ");
            string userInput = Console.ReadLine();
            if (CheckAnswer(userInput, conjugatedVerb))
            {
                Console.WriteLine("Correct!");
                word.SetLearned();
            }
            else
            {
                Console.WriteLine("Incorrect");
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
    public int SelectRandomForm()
    {
        Console.WriteLine("Fix this.");
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _selectedWords.Count);
        return randomIndex;
    }

    public override void EndQuiz()
    {
        throw new NotImplementedException();
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
            Console.WriteLine($"{verb}, {definition}, {conjugations}, {conjugationList} {isIrregular}, {isLearned}");

            Word newWord = new Word(verb, definition, conjugationList, isIrregular, isLearned);
            Console.WriteLine(newWord);
            _verbs.Add(newWord);
        }
        // return _verbs;
    }
}