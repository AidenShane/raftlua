using System.Reflection;

namespace RaftLua.Core.cpackages;

public static class Debug
{
    public static readonly string version = (Assembly.GetExecutingAssembly()
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "unknown").Split("+")[0];
}