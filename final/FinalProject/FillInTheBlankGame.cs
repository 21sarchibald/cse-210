class FillInTheBlankGame : Game
{
    private int _numberOfQuestions;
    List<string> _sentences;
    public FillInTheBlankGame(int numberOfQuestions)
    {
        _numberOfQuestions = numberOfQuestions;
    }
    
    private string RemoveRandomWord()
    {
        return "removedWord"; // FIX THIS.
    }
    public void DisplayBlankSentence()
    {

    }
    public override void CheckAnswer()
    {
        throw new NotImplementedException();
    }

    public override void EndGame()
    {
        throw new NotImplementedException();
    }

    public override void StartGame()
    {
        throw new NotImplementedException();
    }
}