using System.Reflection;

namespace RaftLua.src.Packages;

public static class Debug
{
    public static readonly string version = (Assembly.GetExecutingAssembly()
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "unknown").Split("+")[0];
}