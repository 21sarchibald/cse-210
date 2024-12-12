using System.Reflection;

abstract class Quiz
{
    protected string _title;
    protected string _instructions;
    protected int _numberOfQuestions;

    public Quiz(int numberOfQuestions)
    {
        _numberOfQuestions = numberOfQuestions;
    }

    public abstract void StartQuiz();
    public abstract void DisplayRandomWord();
    public abstract void CheckAnswer();
    public abstract void EndQuiz();
}