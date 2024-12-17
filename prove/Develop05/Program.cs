using System;

class Program
{
    static void Main(string[] args)
    {
        while (menu)
        {
            Console.WriteLine("\nMenu Options:");
            Thread.Sleep(1500);
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Thread.Sleep(1500);
            Console.Write("\nSelect a choice from the menu:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathe = new BreathingActivity("\nBreathing", "\nwalking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                    breathe.DisplayStartingMessage();
                    breathe.bRun();
                    break;

                case "2":
                    ReflectingActivity reflect = new ReflectingActivity("\nReflecting", "\nreflecting on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, "0");
                    reflect.DisplayStartingMessage();
                    reflect.rRun();
                    break;

                case "3":
                    ListingActivity list = new ListingActivity("\nListing", "\nreflecting on the good things in your life by having you list as many things as you can in a certain area", 0, 0);
                    list.DisplayStartingMessage();
                    list.lRun();
                    break;

                case "4":
                    menu = false;
                    break;

                default:
                    Console.WriteLine("\nYou have entered an incorrect prompt! \nPlease try again...");
                    break;
            }
        }
    }


    static bool menu = true;

}