using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade in terms of percent?");
        string grade = Console.ReadLine();
        int g = int.Parse(grade);
        string letterg = "E";

        if (g >= 90)
        {
            letterg = "A";
        }
        else if (g >= 80)
        {
            letterg = "B";
        }
        else if (g >= 70)
        {
            letterg = "C";
        }
        else if (g >= 60)
        {
            letterg = "D";
        }
        else
        {
            letterg = "F";
        }

        Console.WriteLine($"Your letter grade for this class is a(n) {letterg}7");

        if (g > 70)
        {
            Console.WriteLine("Terrific! You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, but you get another chance.");
        }
    }
}