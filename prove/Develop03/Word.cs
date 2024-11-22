public class Word 
{

    private string _hiddenWord;

    public bool _isHidden;

    public string _word;

    static Scripture scripture = new Scripture();
    List<Word> _words = scripture.GetWords();

    public void SetWord(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public string HideWord(string word)
    {
        int length = word.Length;
        _hiddenWord = "";

        for (int i = 0; i < length; i++)
        {
            _hiddenWord += "_";
        }
        _isHidden = true;
        return _hiddenWord;
    }





}