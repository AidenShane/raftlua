namespace RaftLua.src.Packages;

static class Log
{
    static public string prefix = "[RAFTLUA]";

    static private string ConcatenateText(string[] text)
    {
        string newText = "";

        foreach (var item in text)
        {
            newText += item;
        }

        return newText;
    }

    static public void Charout(string[] text)
    {
        string full = prefix + ": " + ConcatenateText(text);

        Console.WriteLine(full);
    }
}