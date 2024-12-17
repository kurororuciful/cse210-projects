class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public string name
    {
        get { return _name ; }
        set { _name = value ; }
    }

    public string description
    {
        get { return _description ; }
        set { _description = value ; }
    }

    public int duration
    {
        get { return _duration; }
        set { _duration = value ; }
    }


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {name} Activity! ");
        Console.WriteLine($"\nThis activity will help you relax by {description}. ");
        
        int cursorTop = Console.CursorTop;
        int cursorLeft = Console.CursorLeft;
        Console.SetCursorPosition(cursorLeft, cursorTop -1);
        Console.WriteLine(new string(' ' , Console.WindowWidth));
        Console.SetCursorPosition(cursorLeft, cursorTop -1);
        
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
      }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!! ");
        ShowSpinner();
        Console.WriteLine($"\nYou have completed another {duration} seconds of the {name} Activity");
        Thread.Sleep(1500);
        ReturnToMenu();
    }   

    public void ShowSpinner()
    {
        int x = 5;
        while (x != 0) 
        {
            x --;
            Console.Write("|");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(150);
            Console.Write("\b \b");        
            Console.Write("-");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(150);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDownSeconds()
    {
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
    }

    public void ReturnToMenu()
    {
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }

}
