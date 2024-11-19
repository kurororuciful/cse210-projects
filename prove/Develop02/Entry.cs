public class Entry
{

    // RESPONSIBILITIES OR MEMBER VARIABLES
    public string _date = DateTime.getDate();
    public string _promptText = "";
    public string _entryText = "";


    // DEFAULT OR CONSTRUCTOR FUNCTION
    public Entry()
    {
        _date = "Missing Date";
        _promptText = "Missing Prompt";
        _entryText = "Missing Entry";
    }


    public void Display()
    {

    }


    public void EntryInfo()
    {
        Console.WriteLine($"{_date} /n {_promptText} /n {_entryText}");
    }

    public class DateTime()
    {
        DateTime getDate = DateTime.Now;
        string dateText = getDate.ToShortDateString();
    }
}