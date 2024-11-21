public class Journal
{
    static List<Entry> _entries;

    static void AddEntry(Entry newEntry)
    {

    }

    static void DisplayAll()
    {

        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.EntryInfo());
        }

    }

    static void SaveToFile(string file)
    {

    }

    static void LoadFromFile(string file)
    {

    }
}