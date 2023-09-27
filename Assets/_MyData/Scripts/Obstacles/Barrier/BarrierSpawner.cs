
using UnityEngine;

public class BarrierSpawner : Spawner
{
    private static BarrierSpawner instance;
    public static BarrierSpawner Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (BarrierSpawner.instance != null) Debug.LogError("Only 1 BarrierSpawner allow to exist");
        BarrierSpawner.instance = this;
    }
}
