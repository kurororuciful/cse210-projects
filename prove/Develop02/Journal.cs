public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        
    }

    public void DisplayAll()
    {
        
        foreach (Entry entry in _entries)
        {
            entry.EntryInfo();
        }
        
    }

    public void SaveToFile(string file)
    {
        
    }

    public void LoadFromFile(string file)
    {
        
    }
}