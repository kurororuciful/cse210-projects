class Assignment
{
    protected string _studentName;
    protected string _topic;


    public string studentName
    {
        get {return _studentName; }
        set { _studentName = value; } 
    }

    public string topic
    {
        get {return _topic; }
        set { _topic = value; }
    }


    public Assignment (string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }


    public string GetSummary()
    {
        return $"\nStudent Name: {studentName}\nTopic: {topic}";
    }

}