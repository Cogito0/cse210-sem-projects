using System.IO;
class Journal
{
    public static List<Entry> _entries = new();


    public static void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public static void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine(e.DisplayEntry() + "\n");
        }
    }

    public static void SaveToFile()
    {
        Console.WriteLine("What do you want to name your journal file?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e.DisplayEntry() + "\n");
            }
        }
    }

    public static void LoadFromFile()
    {

    }
}