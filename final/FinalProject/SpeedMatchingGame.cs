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