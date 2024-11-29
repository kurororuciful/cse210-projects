class Scripture
{

    // PRIVATE ATTRIBUTES OR FIELDS
    private string _reference;
    private List<Word> _word;


    // GETTERS AND SETTERS FOR WRAPPER PROPERTY
    public string reference
    {
        get { return _reference; }
        set { _reference = value; }
    }

    public List<Word> word
    {
        get { return _word; }
        set { _word = value; }
    }


    // CONSTRUCTORS
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _word = new List<Word>(); // Initialization of list

        // Splitting and creating of word objects
        string[] textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            _word.Add(new Word(word)); 
        }
    }


    // DISPLAY METHOD
    public string DisplayText(Reference reference)
    {
        return reference.GetDisplayText();
    }

    // HIDE METHOD
    public string HideRandomWords()
    {
        Random random = new Random();
        int countHideWord = random.Next(1, _word.Count); // Change int value for count of words to hide

        for (int i = 0; i < countHideWord; i++)
        {
            int randomIndex = random.Next(0, _word.Count); 
            _word[randomIndex].isHidden = true;
        }

        string withHiddenText = string.Join(" ", _word.Select(w => w.isHidden ? new string('_', w._text.Length) : w._text));
        return withHiddenText;
                
    }

}