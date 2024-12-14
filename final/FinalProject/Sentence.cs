class Sentence 
{
    private string _sentence;
    public string[] _sentenceWords;
    public string _wordToRemove;
    public int _wordToRemoveIndex;
    public string _meaning;


    public Sentence(string sentence, string[] sentenceWords, string wordToRemove, int wordToRemoveIndex, string meaning)
    {
        _sentence = sentence;
        _sentenceWords = sentenceWords;
        _wordToRemove = wordToRemove;
        _wordToRemoveIndex = wordToRemoveIndex;
        _meaning = meaning;
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