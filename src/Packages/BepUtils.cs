using System.IO;
using Microsoft.VisualBasic;

namespace RaftLua.src.Packages;

public static class BepUtils
{
    private readonly static string CheckDirectoryGame= String.Join("/", 
        ["", "home", Environment.UserName, ".steam", "steam", "steamapps", "common", "Raft"]
    );

    private readonly static string CheckDirectoryBep = Path.Join(CheckDirectoryGame, "BepInEx/Plugins");

    public static bool CheckForBepInEx()
    {
        bool result = false;

        result = File.Exists(CheckDirectoryBep);

        return result;
    }

    public static bool CheckForGame()
    {
        bool result = false;

        result = File.Exists(CheckDirectoryGame);

        return result;
    }
}