using MoonSharp.Interpreter;

namespace RaftLua.src.API;

public class VersionAPI : ILuaApi
{
    public void Register(Script lua, Table raft)
    {
        raft["Version"] = Packages.Debug.version.ToString();
    }
}