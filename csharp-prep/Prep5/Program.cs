using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static void PromptUserBirthYear(out int year)
        {
            Console.WriteLine("What is your birth year?");
            year = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int x)
        {
            return x*x;
        }

        static void DisplayResult(string username, int nsq, int year)
        {
            int age = 2026 - year;
            Console.WriteLine(username + ", the square of your number is " + nsq);
            Console.WriteLine($"{username}, you will turn {age} this year.");
        }
        
        DisplayWelcome();
        string name = PromptUserName();
        int faveN = PromptUserNumber();
        int birthYear = 0;
        PromptUserBirthYear(out birthYear);
        DisplayResult(name, SquareNumber(faveN), birthYear);
    }
}