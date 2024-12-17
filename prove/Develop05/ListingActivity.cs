class ListingActivity : Activity
{
    private int _count;
    private List<string> _lPrompts;
    private List<string> _lInputs;


    public int count
    {
        get { return _count ; }
        set { _count = value ; }
    }

    public List<string> prompts
    {
        get { return _lPrompts; }
        set { _lPrompts = value ; }
    }

    public List<string> inputs
    {
        get { return _lInputs; }
        set { _lInputs = value ; }
    }


    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
        _lPrompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",  
        };
        _lInputs = new List<string>();
    }


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_lPrompts.Count);
        return _lPrompts[index];
    }

   
    public void lRun()
    {
        count = 0;
        Console.WriteLine("Get Ready... \n");
        ShowSpinner();
        Thread.Sleep(2000);

            
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration); 

        Console.WriteLine("\nTake time to list all related answers in your mind...");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());            
        Thread.Sleep(5000);
        ShowSpinner();
        while (DateTime.Now < futureTime)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "")
            {
                break;
            }else
            {
                _lInputs.Add(input);
                count++;
            }
        }

        Console.WriteLine($"\nYou are able to write {count} items!");
        DisplayEndingMessage();
        ShowSpinner();


    }

}