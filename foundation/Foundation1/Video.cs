class Video
{

    // PRIVATE ATTRIBUTES OR FIELDS
    private string _vTitle;
    private string _vAuthor;
    private string _vDuration;
    private List<Comment> _vComments;


    // GETTERS AND SETTERS FOR WRAPPER PROPERTY
    public string title
    {
        get { return _vTitle ; }
        set { _vTitle = value ; }
    }

    public string author
    {
        get { return _vAuthor ; }
        set { _vAuthor = value ; }
    }

    public string duration
    {
        get { return _vDuration ; }
        set { _vDuration = value ; }
    }

    public List<Comment> videoComment
    {
        get { return _vComments;}
        set { _vComments = value;}
    }


    // CONSTRUCTOR FOR VIDEOS
    public Video(string title, string author, string duration)
    {
        _vTitle = title;
        _vAuthor = author;
        _vDuration = duration;
        _vComments = new List<Comment>();
    }


    // METHOD FOR DISPLAYING VIDEO DETAILS
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {title}, \nBy: {author}, \nDuration in Seconds: {duration}");
        return;
    }

}