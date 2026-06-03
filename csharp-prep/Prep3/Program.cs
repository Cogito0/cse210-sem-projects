using System;

class Program
{
    static void Main(string[] args)
    {
        Random rgen = new Random();
        int n = rgen.Next(1,101);
        int g = 0;

        do
        {
            Console.WriteLine("Guess the magic number: ");
            string guess = Console.ReadLine();
            g = int.Parse(guess);

            if (g < n)
            {
                Console.WriteLine("Higher");
            }
            else if (g > n)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            
        } while (g != n);
    }
}