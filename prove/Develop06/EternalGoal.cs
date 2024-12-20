class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

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