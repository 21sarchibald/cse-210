class ConjugationQuiz : Quiz
{
    List<Word> _verbs;
    List<string> _forms;
    public ConjugationQuiz(int numberOfQuestions) : base(numberOfQuestions)
    {

    }
    public override void StartQuiz()
    {
        throw new NotImplementedException();
    }
    public override void CheckAnswer()
    {
        throw new NotImplementedException();
    }

    public override void DisplayRandomWord()
    {
        throw new NotImplementedException();
    }
    public void DisplayRandomForm()
    {
        Console.WriteLine("Fix this.");
    }

    public override void EndQuiz()
    {
        throw new NotImplementedException();
    }

}