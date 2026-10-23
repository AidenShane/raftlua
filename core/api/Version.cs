
using MoonSharp.Interpreter;

namespace RaftLua.Core.API;

public static class Version
{
    public static void Register(Script lua, Table raft)
    {
        #pragma warning disable
        raft["Version"] = cpackages.Debug.version.ToString();
    }
}
