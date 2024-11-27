public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string FractionInfo()
    {
        Console.WriteLine($"{_top} / {_bottom} ");
        string top = Console.ReadLine();
    }


    public double DecimalInfo()
    {
        Console.WriteLine($"{_top} / {_bottom} ")
        double top = Console.ReadLine();
    }

}