using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment paper1 = new MathAssignment("Michael Kelsey", "Synthetic Division", "5.12", "39-49");
        WritingAssignment paper2 = new WritingAssignment("Michael Kelsey", "Poetry in Religion", "How to analyze chiasmus in the Bible");

        Console.WriteLine(paper1.GetSummary());
        Console.WriteLine(paper1.GetHomeworkList());
 
        Console.WriteLine(paper2.GetSummary());
        Console.WriteLine(paper2.GetWritingInformation());
    }
}