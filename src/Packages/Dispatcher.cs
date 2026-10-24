using MoonSharp;
using MoonSharp.Interpreter;

namespace RaftLua.src.Packages;

public static class Dispatcher
{
    public static event EventHandler? Error;
    public static void LuaError(string error)
    {
        string full = String.Join(" ", ["RaftLua encountered an error:", error]);

        Log.CharOut([full]);

        Error?.Invoke(null, new ErrorEventArgs(error));
    }

    public static DynValue ConvertValToLua(Script script, object val)
    {
        return DynValue.FromObject(script, val);
    }
}

public class ErrorEventArgs(string data) : EventArgs
{
    public string Error { get; } = data;
}