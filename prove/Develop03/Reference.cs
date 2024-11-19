class Reference {

    private string _reference;
    public void DisplayReference()
    {
        Console.WriteLine(_reference);
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public string GetReference()
    {
        return _reference;
    }
}