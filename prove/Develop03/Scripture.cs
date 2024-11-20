class Scripture {

    private List <string> _words = new List<string>();

    private string _scripture;

    static Reference reference = new Reference();
    string _reference = reference.GetReference();

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
        reference.DisplayReference();
        Console.WriteLine(_scripture);
    }
    public void SplitScripture()
    {
        string[] words = _scripture.Split(" ");

        // Testing that the function really split it at the spaces.
        foreach (string word in words)
            _words.Add(word);

    }

    public string SelectRandomWord()
    {
        Random rnd = new Random();

        int randomIndex = rnd.Next(0, _words.Count);
        string randomWord = _words[randomIndex];
        Console.WriteLine($"> {randomWord}");
        return randomWord;
    }

}