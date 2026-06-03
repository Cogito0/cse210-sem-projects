using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        int ans = 0;
        int max = 0;
        do
        {
            Console.WriteLine("Enter a number (enter 0 to stop loop): ");
            ans = int.Parse(Console.ReadLine());
            numbers.Add(ans);
            if ((ans < 0 && max == 0) || (max < ans && ans != 0))
            {
                max = ans;
            }

        } while (ans != 0);

        int sum = numbers.Sum();
        double mean = sum / (numbers.Count - 1.0);

        Console.WriteLine($"The sum of your numbers: {sum}");
        Console.WriteLine($"The mean of your numbers: {mean}");
        Console.WriteLine($"The highest number out of your numbers: {max}");
    }
}