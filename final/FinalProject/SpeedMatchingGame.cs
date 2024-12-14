class SpeedMatchingGame : Game
{
    private int _duration;
    private int _correctCount;
    private int _incorrectCount;
    private List<string> _definitions;
    public SpeedMatchingGame(int duration)
    {
        _duration = duration;
    }
    public override void StartGame()
    {
        throw new NotImplementedException();
    }
    public void DisplayRandomWord()
    {
        
    }
    public void DisplayDefinitionsI()
    {

    }
    public override bool CheckAnswer(string userInput, string correctAnswer)
    {
        throw new NotImplementedException();
    }

    public override void EndGame()
    {
        throw new NotImplementedException();
    }

}