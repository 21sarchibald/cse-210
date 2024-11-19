class Scripture {

    private List <string> _words = new List<string>();

    private string _scripture;

    public void SetScripture(string scripture)
    {
        _scripture = scripture;
    }

    public string GetScripture()
    {
        return _scripture;
    }
    

    public void Display()
    {

    }

    public void SplitScripture()
    {
        string[] words = _scripture.Split(" ");
        foreach (string word in words)
            Console.WriteLine(word);

    }

}