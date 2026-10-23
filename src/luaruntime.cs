using System;
using System.Linq;
using System.Reflection;
using MoonSharp.Interpreter;
using RaftLua.src.API;

namespace RaftLua.src;

public class LuaRuntime
{
    private readonly Script _lua;
    private readonly Table _raft;

    public LuaRuntime()
    {
        _lua = new Script();

        _raft = new Table(_lua);
        _lua.Globals["raft"] = _raft;

        RegisterApis();
    }

    private void RegisterApis()
    {
        var apiTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(type =>
                typeof(ILuaApi).IsAssignableFrom(type) &&
                type is { IsClass: true, IsAbstract: false });

        foreach (var type in apiTypes)
        {
            if (Activator.CreateInstance(type) is ILuaApi api)
            {
                api.Register(_lua, _raft);
                Console.WriteLine($"[RAFTLUA]: Registered API {type.Name}");
            }
        }
    }

    public void ExecuteFile(string path)
    {
        _lua.DoFile(path);
    }
}