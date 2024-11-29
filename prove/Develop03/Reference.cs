class Reference
{

    // PRIVATE ATTRIBUTES OR FIELDS
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    

    // GETTERS AND SETTERS FOR WRAPPER PROPERTY
    public string book 
    {
        get {return _book; }
        set {_book = value; }
    }

    public int chapter 
    {
        get {return _chapter;}
        set {_chapter = value;}
    }

    public int verse 
    {
        get {return _verse;}
        set {_verse = value;}
    }

    public int endVerse 
    {
        get {return _endVerse;}
        set {_endVerse = value;}
    }


    // CONSTRUCTORS
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // DISPLAY
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter} : {_verse} ";
        }else 
        {
            return $"{_book} {_chapter} : {_verse} - {_endVerse}";
        }
    }

}