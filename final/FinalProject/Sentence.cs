class Sentence 
{
    private string _meaning;
    private string _wordToRemove;

    public Sentence(string meaning, string wordToRemove)
    {
        _meaning = meaning;
        _wordToRemove = wordToRemove;
    }
    public string RemoveWord()
    {
        int length = _wordToRemove.Length;
        string _hiddenWord = "";

        for (int i = 0; i < length; i++)
        {
            _hiddenWord += "_";
        }
        return _hiddenWord;
    
    }
}