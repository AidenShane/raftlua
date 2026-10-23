using MoonSharp.Interpreter;

namespace RaftLua.src.API;

public class LogAPI : ILuaApi
{
    public void Register(Script lua, Table raft)
    {
        Packages.LuaRegistry.ImplementFunction(
            raft,
            "Log",
            DynValue.NewCallback((context, args) =>
            {
                string message = args.Count > 0
                    ? args[0].ToPrintString()
                    : "";

                Packages.Log.CharOut([message]);

                return DynValue.Nil;
            })
        );
    }
}