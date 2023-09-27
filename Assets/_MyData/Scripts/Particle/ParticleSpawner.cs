
using UnityEngine;

public class ParticleSpawner : Spawner
{
    private static ParticleSpawner instance;
    public static ParticleSpawner Instance => instance;

    protected override void Awake()
    {
        base.Awake();
        if (ParticleSpawner.instance != null) Debug.LogError("Only 1 ParticleSpawner allow to exist");
        ParticleSpawner.instance = this;
    }

}
