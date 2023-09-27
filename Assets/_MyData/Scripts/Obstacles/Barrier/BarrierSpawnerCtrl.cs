
using UnityEngine;

public class BarrierSpawnerCtrl : SpawnerCtrl
{
    [SerializeField] protected BarrierSpawner barrierSpawner;
    public BarrierSpawner BarrierSpawner { get => barrierSpawner; }

    [SerializeField] protected BarrierSpawnPoints spawnPoints;
    public BarrierSpawnPoints SpawnPoints { get => spawnPoints; }

    protected override void LoadSpawner()
    {
        if (this.barrierSpawner != null) { return; }
        else
        {
            this.barrierSpawner = GetComponent<BarrierSpawner>();
        }
    }

    protected override void LoadSpawnPoints()
    {
        if (this.spawnPoints != null) { return; }
        else
        {
            this.spawnPoints = Transform.FindObjectOfType<BarrierSpawnPoints>();
            Debug.Log(transform.name + ": LoadSpawnPoints", gameObject);
        }
    }

}
