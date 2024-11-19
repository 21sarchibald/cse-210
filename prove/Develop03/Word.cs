public class Word 
{
    // private string _word;


    public string HideWord(string word)
    {
        // int length = word.Length;
        string hiddenWord = word.Replace(word, "-");
        Console.WriteLine(hiddenWord);
        return hiddenWord;
    }

}