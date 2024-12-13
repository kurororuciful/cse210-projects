using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        string ass1 = assignment1.GetSummary();
        string math1 = assignment1.GetHomeworkList();
        Console.WriteLine(ass1);
        Console.WriteLine(math1);


        WritingAssignment assignment2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string ass2 = assignment2.GetSummary();
        string write2 = assignment2.GetWritingInformation();
        Console.WriteLine(ass2);
        Console.WriteLine(write2);

    }
}