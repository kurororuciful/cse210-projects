using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager m = new GoalManager();
        m.Start();
        m.DisplayPlayerInfo();

        while (true)
        {
            Console.WriteLine($"Welcome to Goal Tracker!!");
            Thread.Sleep(2000);
            Console.WriteLine($"Kindly select from the options below:");
            Thread.Sleep(500);
            Console.WriteLine($"   1. Create New Goal");
            Thread.Sleep(500);
            Console.WriteLine($"   2. List Goals");
            Thread.Sleep(500);
            Console.WriteLine($"   3. Save Goals");
            Thread.Sleep(500);
            Console.WriteLine($"   4. Load Goals");
            Thread.Sleep(500);
            Console.WriteLine($"   5. Record Event");
            Thread.Sleep(500);
            Console.WriteLine($"   6. Exit");
            Thread.Sleep(500);
            Console.Write($"Please enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        m.CreateGoal();
                        break;
                    case 2:
                        m.ListGoalNames();
                        break;
                    case 3:
                        m.SaveGoals();
                        break;
                    case 4:
                        m.LoadGoals();
                        break;
                    case 5:
                        m.RecordEvent();
                        break;
                    case 6:
                        Console.WriteLine($"Thank you, come again for more goals!");
                        return;
                    default:
                        Console.WriteLine($"That is an invalid choice. \nPlease try again by choosing the number from the menu...");
                        break;
                }
            }else
            {
                Console.WriteLine($"Sorry but that is invalid. \nPlease enter a number from the menu...");
            }
        }
    }
}