class Shape
{
    private string _color = "none";


    public string color
    {
        get { return _color ; }
        set { _color = value ; }
    }


    public Shape(string color)
    {
        _color = color;
    }


    public virtual string GetColor()
    {
        return color;
    }


    public virtual double GetArea()
    {
        return 0;
    }
}
