class Reference {

    private string _reference;
    public void DisplayReference()
    {
        Console.Write($"{_reference} ");
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