
using UnityEngine;

public class ItemSpawner : Spawner
{
    private static ItemSpawner instance;
    public static ItemSpawner Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (ItemSpawner.instance != null) Debug.LogError("Only 1 ItemSpawner allow to exist");
        ItemSpawner.instance = this;
    }
}
