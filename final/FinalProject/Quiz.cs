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
    public abstract void LoadVerbs();
    public abstract List<Word> SelectRandomWords();
    public abstract bool CheckAnswer(string userInput, string correctAnswer);
    public abstract void EndQuiz();
}