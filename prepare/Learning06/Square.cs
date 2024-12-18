class Square : Shape
{
    private double _side = 0;


    public double side
    {
        get { return _side ; }
        set { _side = value ; }
    }


    public Square(string color, double side) : base(color)
    {
        _side = side;
    }


    public override double GetArea()
    {
        return side * side;
    }
}