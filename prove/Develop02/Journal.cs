using System.IO;
class Journal
{
    public static List<Entry> _entries = new();
    public static string[] entries = [];

    public static void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public static void DisplayEntries()
    {
        foreach (string en in entries)
        {
            Console.WriteLine(en);
        }
        foreach (Entry e in _entries)
        {
            Console.WriteLine(e.DisplayEntry() + "\n");
        }
    }

    public static void LoadFromFile()
    {
        Console.WriteLine("What is the name of your journal file?");
        string fileName = Console.ReadLine();
        string file = System.IO.File.ReadAllText(fileName);
        _entries.Clear();
        entries = file.Split("*");
        // Can't convert these into _entries because Entry object not castable.
        DisplayEntries();
    }

    public static void SaveToFile()
    {
        Console.WriteLine("What do you want to name your journal file?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string en in entries)
            {
                outputFile.WriteLine(en + "*");
            }
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e.DisplayEntry() + "*\n");
            }
        }
    }
}