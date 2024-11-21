using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine($"/n 1. Write/n 2. Display/n 3. Load/n 4. Save/n 5. Quit");
        Console.Write("What would you like to do? ");
        int x = int.Parse(Console.ReadLine());


        switch (x)
        {
            case 1:
            {
                Console.WriteLine(PromptGenerator.GetRandomPrompt());
                break;
            }

            case 2:
            {
                Console.WriteLine(Journal.DisplayAll());
                break;
            }

            case 3:
            {
                //LOAD ENTRIES 
                break;
            }

            case 4:
            {
                //SAVE ENTRIES
                break;
            }

            case 5:
            {
                //EXIT
                break;
            }
        }

        
    
/*      THINGS TO PONDER
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
*/        
        

    
    }
}