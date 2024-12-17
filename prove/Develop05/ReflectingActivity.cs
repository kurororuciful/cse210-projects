class ReflectingActivity : Activity
{
    private List<string> _rPrompts;
    private List<string> _rQuestions;


    public List<string> rPrompts
    {
        get { return _rPrompts ; }
        set { _rPrompts = value ; }
    }

    public List<string> rQuestions
    {
        get { return _rQuestions;}
        set { _rQuestions = value;}
    }


    public ReflectingActivity(string name, string description, int duration, string rPrompt) : base(name, description, duration)
    {
        _rPrompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _rQuestions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_rPrompts.Count);
        return _rPrompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_rQuestions.Count);
        return _rQuestions[index];
    }

    public void rRun()
    {
        Console.WriteLine("Get Ready... \n");
        ShowSpinner();
        Thread.Sleep(2000);

            
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration); 

        Console.WriteLine("\nTake some time to reflect on this...");
        Console.WriteLine(GetRandomPrompt());
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine(GetRandomQuestion());
            Thread.Sleep(10000);
        }

        DisplayEndingMessage();
        ShowSpinner();

    }
    
}
