using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.FractionInfo());
        Console.WriteLine(fraction1.DecimalInfo());
        // fraction1._top    = 1;
        // fraction1._bottom = 1;



        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.FractionInfo());
        Console.WriteLine(fraction2.DecimalInfo());
        
        // fraction2._top    = 6;
        // fraction2._bottom = 1;



        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.FractionInfo());
        Console.WriteLine(fraction3.DecimalInfo());
        
        // fraction3._top    = 6;
        // fraction3._bottom = 7;


        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.FractionInfo());
        Console.WriteLine(fraction4.DecimalInfo());


        foreach (Fraction fraction in fraction)
        {
            Fraction myFraction = new Fraction();
            {
                myFraction.FractionInfo();
            }
        }
    }
}