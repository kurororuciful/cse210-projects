class Rectangle  : Shape
{
    private double _length;
    private double _width;


    public double length
    {
        get { return _length ; }
        set { _length = value ; }
    }

    public double width
    {
        get { return _width ; }
        set { _width = value ; }
    }


    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }


    public override double GetArea()
    {
        return length * width;
    }
}