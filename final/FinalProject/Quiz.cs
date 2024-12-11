using System.Reflection;

abstract class Quiz
{
    protected string _title;
    protected string _instructions;

    public Quiz()
    {
   
    }

    public abstract void StartQuiz();
    public abstract void DisplayRandomWord();
    public abstract void CheckAnswer();
    public abstract void EndQuiz();
}