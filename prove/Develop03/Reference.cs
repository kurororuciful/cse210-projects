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
    public Reference(string _book, int _chapter, int _verse);
    {
        book = _book;
        chapter = _chapter;
        verse = _verse;

    }
    
    public Reference(string _book, int _chapter, int _verse, int _endVerse);
    {
        book = _book;
        chapter = _chapter;
        startVerse = _verse;
        endVerse = _endVerse;
    }

}