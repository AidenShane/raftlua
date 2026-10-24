using Unity;
using _Raft;
using System.Numerics;
using MoonSharp.Interpreter;
using RaftLua.src.Packages.Classes;
using UnityEngine;

namespace RaftLua.src.Packages;

public class RaftPackage(Script script)
{
    private readonly Script Script = script;

    public void InitializePackage()
    {
        
    }

    public UnityEngine.Vector3 GetRaftDirection()
    {
        return Raft.direction;

        
    }
}