using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string given = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string family = Console.ReadLine();
        Console.WriteLine($"Your name is {family}, {given} {family}.");
    }
}