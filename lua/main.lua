local function testLua()
    print("Lua is running!")
end

local function testApi()
    print("-- API --")
    for key, value in pairs(raft) do
        print(string.format("[%s]: %s", key, tostring(value)))
    end
    print("-- END --")
    raft.Log("Version: "..raft.Version)
    raft.Error("This is a test error!")
end

testLua()
testApi()