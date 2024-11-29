using System;

class Program
{
    static void Main(string[] args)
    {
        Reference myReference = new Reference("John", 3, 16);
        string displayText = myReference.GetDisplayText();
        Console.WriteLine(displayText);

        
    }
}