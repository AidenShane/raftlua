
using MoonSharp.Interpreter;

namespace RaftLua.src.API;

public static class Version
{
    public static void Register(Script lua, Table raft)
    {
        #pragma warning disable
        raft["Version"] = Packages.Debug.version.ToString();
    }
}
