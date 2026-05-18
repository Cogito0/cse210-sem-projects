class Entry
{
    public string _name = "Michael Kelsey";
    public string _date = "";
    public static PromptGenerator pGen = new();
    public string _prompt = pGen.GetRandomPrompt();
    public string _response = "";

    public string DisplayEntry(bool fromLoad=false)
    {   
        if (fromLoad == true)
        {
            return _response;
        } else {
        return $"{_name} {_date}\n{_prompt}\n{_response}";
        }
    }
}