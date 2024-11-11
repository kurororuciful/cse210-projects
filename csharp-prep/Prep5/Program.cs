using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        /*  I Copied the Sample Solution for Future Reference.
            My real answer (which btw is far from the answer) 
            can be seen at the bottom*/ 

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquaredNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
        //  #####################################################
        /*  THIS BELOW IS WHAT I DID, SO FAR FROM WHAT IT SHOULD BE
            PERHAPS I LACK UNDERSTANDING OF INSTRUCTION SINCE BEEN SLEEPLESS
       
        string DisplayWelcome = "Welcome to the Program! ";


        Console.WriteLine($"{DisplayWelcome}");
    

        static string PromptUserName(string userName)
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        static PromptUserNumber(int userNumber) 
        {
            Console.Write("Please enter your favorite number? ");
            return userNumber;
            static int SquareNumber()

        Console.WriteLine($"{PromptUserName}, the square of your number is {}");
        */