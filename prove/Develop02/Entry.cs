public class Entry
{

    // RESPONSIBILITIES OR MEMBER VARIABLES
    public static string _date = DateTime.dateText();
    public static string _promptText = "";
    public static string _entryText = "";


    // DEFAULT OR CONSTRUCTOR FUNCTION
    public Entry()
    {
        _date = "Missing Date";
        _promptText = "Missing Prompt";
        _entryText = "Missing Entry";
    }


    public Display()
    {

    }


    public static string EntryInfo()
    {
        Console.WriteLine($"{_date} /n {_promptText} /n {_entryText}");
    }

    public consta string DateTime()
    {
        DateTime getDate = DateTime.Now;
        string dateText = getDate.ToShortDateString();
    }
}