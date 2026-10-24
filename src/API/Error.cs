using MoonSharp.Interpreter;

namespace RaftLua.src.API;

public class Error : ILuaApi
{
    public void Register(Script lua, Table raft)
    {
        Packages.LuaRegistry.ImplementFunction(
            raft,
            "Error",
            DynValue.NewCallback((context, args) =>
            {
                string message = args.Count > 0
                    ? args[0].ToPrintString()
                    : "";

                Packages.Dispatcher.LuaError(message);

                return DynValue.Nil;
            })
        );
    }
}