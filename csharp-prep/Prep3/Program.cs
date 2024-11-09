using System;

class Program
{
    static void Main(string[] args)
    {
        /* ASSIGNMENT 1 AND 2
        Console.WriteLine("What is the magic number? ");
        string input = Console.ReadLine();
        int y = int.Parse(input);
        */

        // ASSIGNMENT 3
        Random randomGenerator = new Random();
        int y = randomGenerator.Next(1,100);    

        int x = 0;
        string ask = "What is your guess? ";

        Console.WriteLine("Guess a number between 1 to 100...");

        while (x != y)
        {
            Console.WriteLine(ask);
            string guess = Console.ReadLine();
            x = int.Parse(guess);

            if (x > y)
            {
                Console.WriteLine("Lower!");
            }
            else if (x < y)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("You got it!!!");
            }
        }         
    }
}