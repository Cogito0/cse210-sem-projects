using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        while (answer != "Q")
        {
            Console.WriteLine(@"'N' for new entry
'P' for print journal
'S' for save current journal
'L' for load journal
'Q' for quit");
            Console.WriteLine($"{Journal._entries.Count} entries in current journal.");
            answer = Console.ReadLine();
            if (answer == "N")
            {
                Entry newEntry = new();
                DateTime now = DateTime.Now;
                newEntry._date = now.ToShortDateString();
                newEntry._response = Console.ReadLine();
                Journal.AddEntry(newEntry);
            } else if (answer == "P")
            {
                Journal.DisplayEntries();
            } else if (answer == "S")
            {
                Journal.SaveToFile();
            } else if (answer == "L")
            {
                Journal.LoadFromFile();
            }
        }
    }
}