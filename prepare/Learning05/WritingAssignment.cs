class WritingAssignment : Assignment
{
    private string _title;


    public string title
    {
        get { return _title; }
        set { _title = value; }
    }


    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }


    public string GetWritingInformation()
    {
        return $"Title: {title}\n";
    }
}