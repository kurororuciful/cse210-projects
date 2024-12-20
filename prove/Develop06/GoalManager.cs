class GoalManager
{   
    private List<string> _goals;
    private int _score;


    public List<Goal> goals
    {
        get { return _goals ; }
        protected set { _goals = value ; }
    }

    public int score
    {
        get { return _score ; }
        set { _score = value ; }
    }


    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    } 


    public void Start()
    {
        LoadGoals();
    }


    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }


    public void ListGoalNames() 
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals added yet."); 
            return; 
        }   
        
        Console.WriteLine("Your Active Goals: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.name);
        }
    }


    public void ListGoalDetails() 
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine($"No goals added yet...");
            return;
        }

        Console.WriteLine("Goals Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }


    public void CreateGoal()
    {
        Console.Write($"What kind of goal is this...\n   1. Checklist\n   2. Eternal\n   3. Simple\nWhich type of goal would you like to create?");
        string type = Console.ReadLine();

        switch (type)
        {
            case "1": 
                Console.Write($"What is the name of your goal?");
                string name = Console.ReadLine();
                Console.Write($"Give a brief description of your goal...");
                string description = Console.ReadLine();
                Console.Write($"How many points does this goal have?");
                if (int.TryParse(Console.ReadLine(), out int points))
                {
                    Console.Write($"How many times do you intend to do this?");
                    if (int.TryParse(Console.ReadLine(), out int target))
                    {
                        Console.Write($"If you reach double your goal, you will get bonus points.\nHow much would you like to reward yourself?");
                        if (int.TryParse(Console.ReadLine(), out int bonus))
                        {
                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                            Console.WriteLine($"Checklist goal created! ");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid bonus points...\nPlease enter a number.");
                        }
                    }else
                    {
                        Console.WriteLine($"Invalid points...\nPlease enter a number.");
                    }
                    break;
                }

            case "2":
                Console.Write($"What is the name of your goal? "); 
                name = Console.ReadLine();
                Console.Write($"Give a brief description of your goal...");
                description = Console.ReadLine();
                Console.Write($"How many points does this goal have?");
                if (int.TryParse(Console.ReadLine(), out int points))
                {
                    _goals.Add(new EternalGoal(name, description, points));
                    Console.WriteLine("Eternal goal created! ");
                }else
                {
                    Console.WriteLine($"Invalid points. Please enter a number...");
                }
                break;

            case "3":
                Console.Write($"What is the name of your goal? "); 
                name = Console.ReadLine();
                Console.Write($"Give a brief description of your goal...");
                description = Console.ReadLine();
                Console.Write($"How many points does this goal have?");
                if (int.TryParse(Console.ReadLine(), out int points))
                {
                    Console.Write($"Have you finished working on this yet? (Yes/No)");
                    string finished = Console.ReadLine().ToLower();
                    if (finished == "yes")
                    {
                        bool isComplete();
                    }else
                    {
                        
                    }
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    Console.WriteLine("Simple goal created! "); 
                }else
                {
                    Console.WriteLine($"Invalid points. Please enter a number...");
                }   
                break;
            default:
                Console.WriteLine("Invalid goal type. Please choose 1, 2, or 3.");
                break;
        }
    }  


    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine($"No goals to record events for...");
            return;
        }

        ListGoalNames();

        Console.WriteLine("Enter the number of the goal you have accomplished?");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            selectedGoal.RecordEvent();
            Console.WriteLine($"Congratulations in your new accomplishment: \n{selectedGoal.name}");
        }else
        {
            Console.WriteLine($"Invalid goal selection...");
        }
    }


    public void SaveGoals() 
    {
        Console.WriteLine($"What is the name of the text file you wish to save your goals? ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{goal.name}, {goal.description}, {goal.points}, {goal.IsComplete}");
            }
        }   Console.WriteLine($"Goals saved to {fileName}"); 
    }


    public void LoadGoals() 
    {
        Console.WriteLine($"What is the name of the text file where your goals were saved? ");
        string fileName = Console.ReadLine();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                bool isComplete = bool.Parse(parts[3]);

                _goals.Add(new Goal(name, description, points));
            }
            Console.WriteLine($"Goals have been loaded from {fileName}");
        }
    }
    
}