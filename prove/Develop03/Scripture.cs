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
}