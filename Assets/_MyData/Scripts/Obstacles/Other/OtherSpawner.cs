
using UnityEngine;

public class OtherSpawner : Spawner
{
    private static OtherSpawner instance;
    public static OtherSpawner Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (OtherSpawner.instance != null) Debug.LogError("Only 1 OtherSpawner allow to exist");
        OtherSpawner.instance = this;
    }
}
