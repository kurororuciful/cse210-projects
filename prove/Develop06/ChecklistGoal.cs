class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;


    public int amountCompleted
    {
        get { return _amountCompleted ; }
        set { _amountCompleted = value ; }
    }

    public int target
    {
        get { return _target ; }
        set { _target = value ; }
    }

    public int bonus
    {
        get { return _bonus ; }
        set { _bonus = value ; }
    }


    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }


    public override void RecordEvent()
    {
        base.RecordEvent();
    }


    public override bool IsComplete()
    {
        return base.IsComplete();
    }


    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }


    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}