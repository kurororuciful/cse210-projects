using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string ask = "Enter a number: ";
        int x = -1;
        int sum = 0;
        int lar = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (x != 0)
        {
            Console.Write(ask);
            string num = Console.ReadLine();
            x = int.Parse(num);
            numbers.Add(x);
        }

        foreach (int number in numbers)
        {
            sum += number;
            if (number > lar)
            {
                lar = number;
            }
            /* SHORTCUT FOR ASSIGNMENT 3
            Console.WriteLine($"The largest number is {numbers.Max()}"); */
        }

        Console.WriteLine($"The sum is: {sum} ");

        float ave = ((float) sum) / (numbers.Count - 1);
        Console.WriteLine($"The average is {ave} ");
        Console.WriteLine($"The largest number is {lar} ");
    }
}