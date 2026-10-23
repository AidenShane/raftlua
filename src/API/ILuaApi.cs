using MoonSharp.Interpreter;

namespace RaftLua.src.API;

public interface ILuaApi
{
    void Register(Script lua, Table raft);
}