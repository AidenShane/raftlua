
using MoonSharp.Interpreter;

namespace RaftLua.Core.API;

public static class LogAPI
{
    public static void Register(Script lua, Table raft)
    {
        raft["log"] = DynValue.NewCallback(
            (context, args) =>
            {
                string message = args.Count > 0
                    ? args[0].ToPrintString()
                    : "";

                cpackages.Log.Charout([message]);

                return DynValue.Nil;
            }
        );
    }
}
