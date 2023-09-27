
using UnityEngine;

public class OtherSpawnerCtrl : SpawnerCtrl
{
    [SerializeField] protected OtherSpawner otherSpawner;
    public OtherSpawner OtherSpawner { get => otherSpawner; }

    [SerializeField] protected OtherSpawnPoint spawnPoints;
    public OtherSpawnPoint SpawnPoints { get => spawnPoints; }


    protected override void LoadSpawner()
    {
        if (this.otherSpawner != null) { return; }
        else
        {
            this.otherSpawner = GetComponent<OtherSpawner>();
        }
    }

    protected override void LoadSpawnPoints()
    {
        if (this.spawnPoints != null) { return; }
        else
        {
            this.spawnPoints = Transform.FindObjectOfType<OtherSpawnPoint>();
            Debug.Log(transform.name + ": LoadSpawnPoints", gameObject);
        }
    }
}
