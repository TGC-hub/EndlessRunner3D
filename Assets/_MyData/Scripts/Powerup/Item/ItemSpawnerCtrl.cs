
using UnityEngine;

public class ItemSpawnerCtrl : SpawnerCtrl
{
    [SerializeField] protected ItemSpawner itemSpawner;
    public ItemSpawner ItemSpawner { get => itemSpawner; }

    [SerializeField] protected ItemSpawnPoint spawnPoints;
    public ItemSpawnPoint SpawnPoints { get => spawnPoints; }


    protected override void LoadSpawner()
    {
        if (this.itemSpawner != null) { return; }
        else
        {
            this.itemSpawner = GetComponent<ItemSpawner>();
        }
    }

    protected override void LoadSpawnPoints()
    {
        if (this.spawnPoints != null) { return; }
        else
        {
            this.spawnPoints = Transform.FindObjectOfType<ItemSpawnPoint>();
            Debug.Log(transform.name + ": LoadSpawnPoints", gameObject);
        }
    }
}
