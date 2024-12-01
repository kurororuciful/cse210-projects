class Scripture
{

    // PRIVATE ATTRIBUTES OR FIELDS
    private string _reference;
    private List<Word> _word;


    // GETTERS AND SETTERS FOR WRAPPER PROPERTY
    public string reference
    {
        get { return _reference; }
        set { _reference = value; }
    }

    public List<Word> Word
    {
        get { return _word; }
        set { _word = value; }
    }


    // CONSTRUCTORS
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _word = new List<Word>(); // Initialization of list

        // Splitting and creating of word objects
        string[] textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            _word.Add(new Word(word)); 
        }
    }


    // DISPLAY METHOD
    public string displayText(Reference reference)
    {
        return reference.GetDisplayText();
    }

    // HIDE METHOD
    public string HideRandomWords()
    {
        Random random = new Random();
        int countHideWord = random.Next(1, _word.Count); // Change int value for count of words to hide

        for (int i = 0; i < countHideWord; i++)
        {
            int randomIndex = random.Next(0, _word.Count); 
            _word[randomIndex].isHidden = true;
        }

        string withHiddenText = string.Join(" ", _word.Select(w => w.isHidden ? new string('_', w.text.Length) : w.text));
        return withHiddenText;
                
    }


    public void ScriptureMemorySupport(Reference reference)
    {

        // TEXT WORD
        string text = "For God so loved the world that he gave His only Begotten Son that whosoever believeth in Him should not perish but have everlasting life.";
        
        // REFERENCE IN THE SCRIPTURE OBJECT UPDATE
        this.reference = reference.GetDisplayText();

        // DISPLAY WORD
        Console.WriteLine(this.reference);


        // PROMPTING THE USER
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish ");
            string prompt = Console.ReadLine();

            
            if (prompt.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                // STOPPING THE LOOP BY QUIT
                break;
            }else{
            
                // HIDE RANDOM WORDS
                string withHiddenText = HideRandomWords();
            

                if (_word.All(w => w.isHidden))
                {
                    break;
                }

                // CLEARING CONSOLE
                Console.Clear();

                // DISPLAYING THE VERSE WITH HIDDEN WORDS
                Console.WriteLine(reference.GetDisplayText());
                Console.WriteLine(withHiddenText);
            }
        }
    }
}