using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";

        // CORE REQUIREMENTS
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "E";
        }
        Console.WriteLine($"Your grade is {letter}!");


        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You PASSED! ");
        }
        else
        {
            Console.WriteLine($"Keep it up! You can do it next time. ");
        }
    }
}