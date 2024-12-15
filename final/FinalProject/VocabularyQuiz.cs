using System.Reflection;

class VocabularyQuiz : Quiz
{
    public VocabularyQuiz(int numberOfQuestions) : base(numberOfQuestions)
    {

    }

    public override void StartQuiz()
    {
        throw new NotImplementedException();
    }

    public override bool CheckAnswer(string userInput, string correctAnswer)
    {
        throw new NotImplementedException();
    }

    public override List<Word> SelectRandomWords()
    {
        throw new NotImplementedException();
    }
    public void DisplayDefinition(string word)
    {

    }
    public override void EndQuiz()
    {
        throw new NotImplementedException();
    }

    public override void LoadVerbs()
    {
        throw new NotImplementedException();
    }
}