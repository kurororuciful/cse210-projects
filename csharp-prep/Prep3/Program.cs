using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        string input = Console.ReadLine();
        int magicNumber = int.Parse(input);

        
            Console.WriteLine("What is your guess? ");
            string x = Console.ReadLine();
            int guess = int.Parse(x);

            /*Random randomGenerator = new Random();
            int number = randomGenerator.Next();*/

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        
    }
}