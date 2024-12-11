abstract class Game
{
    
    protected string _title;
    protected string _instructions;
    protected int _points;

    public Game()
    {

    }

    abstract public void StartGame();
    abstract public void CheckAnswer();
    abstract public void EndGame();
}