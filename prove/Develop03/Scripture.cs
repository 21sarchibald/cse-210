using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

class Scripture {

    private List <Word> _words = new List<Word>();

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

    public void SetWords(List<Word> words)
    {
        _words = words;
    }

    public List<Word> GetWords()
    {
        return _words;
    }
    
    public void Display()
    {
        _reference.DisplayReference();
        foreach (Word word in _words)
        {
            Console.Write($"{word._word} ");
        }
    }
    public void SplitScripture()
    {
        string[] words = _scripture.Split(" ");

        foreach (string word in words)
        {
            // _words.Add(word);
            Word _word = new Word();
            _word.SetWord(word);
            _words.Add(_word);
        }
    }

    public int SelectRandomWord()
    {
        Random rnd = new Random();

        int randomIndex = rnd.Next(0, _words.Count);
        return randomIndex;
    }

    public List<Word> HideWords()
    {
        for (int i = 0; i < 3; i++)
        {
            int randomIndex = SelectRandomWord();
            Word randomSelector = _words[randomIndex];
            string randomWord = randomSelector.GetWord();
            string hiddenWord = randomSelector.HideWord(randomWord); // not sure on this.
            _words[randomIndex]._word = hiddenWord;
        }
        return _words;

    }

    public bool IsCompletelyHidden()
    {
        int counter = 0;
        foreach (Word word in _words)
        {
            
            if (word._isHidden)
            {
                counter += 1;
            }
        }
        if (counter == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}