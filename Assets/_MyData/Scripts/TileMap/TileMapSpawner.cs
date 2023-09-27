
using UnityEngine;

public class TileMapSpawner : Spawner
{
    private static TileMapSpawner instance;
    public static TileMapSpawner Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (TileMapSpawner.instance != null) Debug.LogError("Only 1 TileMapSpawner allow to exist");
        TileMapSpawner.instance = this;
    }
}
