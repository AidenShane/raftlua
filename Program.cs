using System;
using System.IO;
using MoonSharp.Interpreter;

class Program
{
    static string luaDir = "lua";

    static void Main()
    {
        var lua = new Script();

        lua.Options.DebugPrint = message =>
            Console.WriteLine(message);

        string scriptPath = Path.Combine(
            Directory.GetCurrentDirectory(),
            luaDir,
            "main.lua"
        );

        if (!File.Exists(scriptPath))
        {
            Console.WriteLine($"Script not found: {scriptPath}");
            return;
        }

        try
        {
            lua.DoFile(scriptPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lua error: {ex.Message}");
        }
    }
}