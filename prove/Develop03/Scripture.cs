using System.Reflection.Metadata;

class Scripture {

    private List <string> _words = new List<string>();

    private string _scripture;

    static Reference _reference = new Reference();
    // string _reference = reference.GetReference();

    public void SetScripture(string scripture)
    {
        _scripture = scripture;
    }

    public string GetScripture()
    {
        return _scripture;
    }

    public void SetWords(List<string> words)
    {
        _words = words;
    }

    public List<string> GetWords()
    {
        return _words;
    }
    
    public void Display()
    {
        _reference.DisplayReference();
        foreach (string word in _words)
        {
            Console.Write($"{word} ");
        }
    }
    public void SplitScripture()
    {
        string[] words = _scripture.Split(" ");

        // Testing that the function really split it at the spaces.
        foreach (string word in words)
            _words.Add(word);

    }

    public int SelectRandomWord()
    {
        Random rnd = new Random();

        int randomIndex = rnd.Next(0, _words.Count);
        // string randomWord = _words[randomIndex];
        // Console.WriteLine($"> {randomWord}");
        return randomIndex;
    }

    public List<string> HideWords()
    {
        for (int i = 0; i < 3; i++)
        {
            int randomIndex = SelectRandomWord();
            Word word = new Word();
            _words[randomIndex] = word.HideWord(_words[randomIndex]);
        }
        return _words;

    }

}