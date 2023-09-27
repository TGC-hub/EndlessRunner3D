
using UnityEngine;

public class AnimalSpawner : Spawner
{
    private static AnimalSpawner instance;
    public static AnimalSpawner Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (AnimalSpawner.instance != null) Debug.LogError("Only 1 AnimalSpawner allow to exist");
        AnimalSpawner.instance = this;
    }
}
