class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;


    public string textbookSection
    {
        get { return _textbookSection ; }
        set { _textbookSection = value ; }
    }

    public string problems
    {
        get { return _problems ; }
        set { _problems = value ; }
    }


    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    } 


    public string GetHomeworkList()
    {
        return $"Textbook Section: {textbookSection}\nProblems: {problems}\n";
    }
}