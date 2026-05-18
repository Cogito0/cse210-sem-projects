using System.IO;
class PromptGenerator
{
    public static string _fileName = "PromptList.txt";
    public string[] _promptList = System.IO.File.ReadAllLines(_fileName);

    public string GetRandomPrompt()
    {
        Random RNG = new();
        string prompt = _promptList[RNG.Next(0, _promptList.Length)];
        Console.WriteLine(prompt);
        return prompt;
    }
}