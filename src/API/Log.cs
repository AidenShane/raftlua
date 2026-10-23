
using MoonSharp.Interpreter;

namespace RaftLua.src.API;

public static class LogAPI
{
    public static void Register(Script lua, Table raft)
    {
    Packages.LuaRegistry.ImplementFunction(
    raft,
    "Log",
    DynValue.NewCallback((context, args) =>
    {
        string message = args.Count > 0
            ? args[0].ToPrintString()
            : "";

        Packages.Log.Charout([message]);

        return DynValue.Nil;
    })
);
    }
}
