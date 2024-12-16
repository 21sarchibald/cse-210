using System.Reflection;

abstract class Quiz
{
    protected int _numberOfQuestions;
    protected int _correctAnswers = 0;

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