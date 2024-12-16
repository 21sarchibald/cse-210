class Word 
{  
    private string _verb;
    private string _definition;
    public string[] _conjugations;
    private bool _isIrregular;
    private bool _isLearned;
    public Word(string verb, string definition, string[] conjugationList, bool isIrregular, bool isLearned)
    {
        _verb = verb;
        _definition = definition;
        _conjugations = conjugationList;
        _isIrregular = isIrregular;
        _isLearned = isLearned;
    }
    private string GetConjugation(string form)
    {
        return _conjugations[0]; // Fix this.
    }
    public void SetLearned()
    {
        _isLearned = true;
    }
    public void SetNotLearned()
    {
        _isLearned = false;
    }
    public string GetVerb()
    {
        return _verb;
    }
}