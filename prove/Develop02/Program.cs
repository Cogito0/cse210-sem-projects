using System;

class Program
{
    static void Main(string[] args)
    {
        Entry newEntry = new();
        DateTime now = DateTime.Now;
        newEntry._date = now.ToShortDateString();
        newEntry._response = Console.ReadLine();

        Journal.AddEntry(newEntry);
        Journal.DisplayEntries();
    }
}