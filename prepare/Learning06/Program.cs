using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("black", 12.4);
        square1.color = "black";
        square1.side = 12.4;
        string color = square1.GetColor();
        double area = square1.GetArea();
    
    
        Rectangle rectangle1 = new Rectangle("gray", 24.7,18.6);
        rectangle1.color = "gray";
        rectangle1.length = 24.7;
        rectangle1.width = 18.6;
        color = rectangle1.GetColor();
        area = rectangle1.GetArea();


        Circle circle1 = new Circle("white", 32.1);
        circle1.color = "white";
        circle1.radius = 32.1;
        color = circle1.GetColor();
        area = circle1.GetArea();


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            DisplayArea(shape);
        }    
    }


    public static void DisplayArea(Shape shape)
    {
            Console.WriteLine($"The area of the {shape.GetColor()} is {shape.GetArea()}. ");
    }

}