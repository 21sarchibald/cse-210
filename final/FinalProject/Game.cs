abstract class Game
{
    protected string _instructions;
    protected int _correctAnswers = 0;

    public Game()
    {

    }

    abstract public void StartGame();
    abstract public bool CheckAnswer(string userInput, string correctAnswer);
    abstract public void EndGame();
}