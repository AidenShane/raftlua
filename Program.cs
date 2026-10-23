
using System;
using System.IO;
using RaftLua.src;

var runtime = new LuaRuntime();

string scriptPath = Path.Combine(
    Directory.GetCurrentDirectory(),
    "lua",
    "main.lua"
);

try
{
    runtime.ExecuteFile(scriptPath);
}
catch (Exception ex)
{
    Console.WriteLine($"Lua error: {ex.Message}");
}
