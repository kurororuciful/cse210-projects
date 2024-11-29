class Word
{

    // PRIVATE ATTRIBUTES OR FIELDS
    public string _text;
    public bool _isHidden;


    // CONSTRUCTORS
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }



    // GETTERS AND SETTERS FOR WRAPPER PROPERTY
    public string text
    {
        get { return _text; }
        set { _text = value; }
    }

    public bool isHidden
    {
        get { return _isHidden; }
        set { _isHidden = value; }
    }

}