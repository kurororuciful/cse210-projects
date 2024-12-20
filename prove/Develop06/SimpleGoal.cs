class SimpleGoal : Goal
{
    private bool _isComplete = false;


    public bool isComplete
    {
        get { return _isComplete ; }
        set { _isComplete = value ; }
    }


    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }


    public override void RecordEvent()
    {
        base.RecordEvent();
    }


    public override bool IsComplete()
    {
        return false;
    }


    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}