class Circle : Shape
{
    private double _radius;


    public double radius
    {
        get { return _radius ; }
        set { _radius = value ; }
    }


    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }


    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}