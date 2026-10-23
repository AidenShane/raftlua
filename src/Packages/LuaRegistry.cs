using MoonSharp.Interpreter;

namespace RaftLua.src.Packages;

public static class LuaRegistry
{
    public static void ImplementFunction(Table raft, string key, DynValue action)
    {
        raft[key] = action;
        Packages.Log.CharOut(["LuaRegistry::ImplementFunction", " " + key]);
    }

    public static void ImplementArbitrary(Table raft, Dictionary<string, object> keyvals)
    {
        foreach (var (key, value) in keyvals)
        {
            if (value == null)
                continue;

            DynValue luaValue = value switch
            {
                string s => DynValue.NewString(s),
                bool b => DynValue.NewBoolean(b),
                int i => DynValue.NewNumber(i),
                long l => DynValue.NewNumber(l),
                float f => DynValue.NewNumber(f),
                double d => DynValue.NewNumber(d),
                _ => DynValue.Nil
            };

            if (luaValue.Type == DataType.Nil)
            {
                Packages.Log.CharOut(
                    [$"[RAFTLUA]: Skipping unsupported value for key '{key}' " +
                    $"({value.GetType().FullName})"]);
                continue;
            }

            raft.Set(key, luaValue);
        }
    }
}