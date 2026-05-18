class Entry
{
    public string _name = "Michael Kelsey";
    public string _date = "";
    public static PromptGenerator pGen = new();
    public string _prompt = pGen.GetRandomPrompt();
    public string _response = "";

    public string DisplayEntry()
    {
        return $"{_name} {_date}\n{_prompt}\n{_response}";
    }
}