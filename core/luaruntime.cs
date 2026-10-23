
using MoonSharp.Interpreter;
using RaftLua.Core.API;

namespace RaftLua.Core;

public class LuaRuntime
{
    private readonly Script _lua;

    public LuaRuntime()
    {
        _lua = new Script();

        var raft = new Table(_lua);
        _lua.Globals["raft"] = raft;

        LogAPI.Register(_lua, raft);
        RaftLua.Core.API.Version.Register(_lua, raft);
    }

    public void ExecuteFile(string path)
    {
        _lua.DoFile(path);
    }
}
