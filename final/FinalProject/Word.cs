class Word 
{
    private string _definition;
    private string _type;
    private List<string> _conjugations;
    private bool _isIrregular;

    private string GetConjugation(string form)
    {
        return _conjugations[0]; // Fix this.
    }
}