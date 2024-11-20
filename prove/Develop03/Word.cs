public class Word 
{
    private string _word;

    private string _hiddenWord;

    static Scripture scripture = new Scripture();
    List<string> _words = scripture.GetWords();



    public string HideWord(string word)
    {
        int length = word.Length;
        _hiddenWord = "";

        for (int i = 0; i < length; i++)
        {
            _hiddenWord += "_";
        }
        return _hiddenWord;
            
    }



}