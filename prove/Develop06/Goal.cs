class Goal
{
    private string _shortName;
    private string _description;
    private int _points;


    public string name
    {
        get { return _shortName ; }
        set { _shortName = value ; }
    }

    public string description
    {
        get { return _description ; }
        set { _description = value ; }
    }

    public int points
    {
        get { return _points ; }
        set { _points = value ; }
    }


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public virtual void RecordEvent()
    {
        Console.WriteLine($"Which among the goals have you completed? ");
        
    }


    public virtual bool IsComplete(GoalManager manager)
    {
        Console.WriteLine($"Congratulations on your new accomplishment! ");
        manager.score += points;
        return true;
    }


    public virtual string GetDetailsString()
    {
        return $"Goal: {name}\nDescription: {description}\nPoints: {points}";
    }


    public virtual string GetStringRepresentation()
    {
        return $"{name} ({points} points)";
    }
}