class Comment
{

    // PRIVATE ATTRIBUTES OR FIELDS
    private string _cName;
    private string _cComment;



    // GETTERS AND SETTERS FOR WRAPPER PROPERTY
    public string name
    {
        get { return _cName; }
        set { _cName = value; }
    }

    public string comment
    {
        get { return _cComment; }
        set { _cComment = value; }
    }


    // CONSTRUCTOR FOR COMMENT
    public Comment(string name, string comment)
    {
        _cName = name;
        _cComment = comment;
    }


    // METHOD FOR COUNTING COMMENT PER VIDEO
    public static Dictionary<string, int> CommentCounter(List<Comment> comments)
    {
        Dictionary<string, int> commentCounts = new Dictionary<string, int>();

        foreach (Comment comment in comments)
        {
            string videoTitle = comment.comment.Split(' ').Last();
            if (commentCounts.ContainsKey(videoTitle))
            {
                commentCounts[videoTitle]++;
            }
            else
            {
                commentCounts[videoTitle] = 1;
            }
        }
        return commentCounts;
    }


    // METHOD FOR DISPLAYING THE COMMENT COUNT PER VIDEO
    public static void DisplayCount(List<Comment>comments)
    {    
        Dictionary<string, int> commentCounts = CommentCounter(comments);
        
        foreach (KeyValuePair<string, int> count in commentCounts)
        {
            Console.WriteLine($"Video Title: {count.Key} \nComment Count: {count.Value}");
        }
    }
}
