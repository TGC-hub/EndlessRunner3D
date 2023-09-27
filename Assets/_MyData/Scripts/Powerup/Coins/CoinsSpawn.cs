
using UnityEngine;

public class CoinsSpawn : Spawner
{
    private static CoinsSpawn instance;
    public static CoinsSpawn Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (CoinsSpawn.instance != null) Debug.LogError("Only 1 CoinsSpawn allow to exist");
        CoinsSpawn.instance = this;
    }
}
